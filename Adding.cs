using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace students
{
    public partial class Adding : Form
    {
        public XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
        public Student[] newStudents;
        public static string surnameToAdd;
        public static string nameToAdd;
        public static string groupToAdd;
        public static int courseToAdd;
        public static int gradeBookIDToAdd;
        public static int ratingToAdd;
        public static string notesToAdd;

        public Adding()
        {
            InitializeComponent();
        }

        private void submitAddButton_Click(object sender, EventArgs e)
        {
            surnameToAdd = surnameToAddTextBox.Text.Trim();
            nameToAdd = nameToAddTextBox.Text.Trim();
            groupToAdd = groupToAddTextBox.Text.Trim();
            bool isGoodCourse = int.TryParse(courseToAddTextBox.Text.Trim(), out courseToAdd);
            bool isGoodBookId = int.TryParse(gradeBookIDToAddTextBox.Text.Trim(), out gradeBookIDToAdd);
            bool isGoodRating = int.TryParse(ratingToAddTextBox.Text.Trim(), out ratingToAdd);
            notesToAdd = notesToAddTextBox.Text;

            var list = GetStudents().Cast<Student>().ToList();
            bool canContinue = false;
            foreach (Student s in list.ToArray())
            {
                if (gradeBookIDToAdd.Equals(s.GradeBookID))
                {
                    MessageBox.Show("Пожалуйста, введите другой номер зачетки!");
                }
            }
             if(surnameToAddTextBox.Text.Length == 0)
            {
                MessageBox.Show("Фамилия не может быть пустой");
            }
            else if (nameToAddTextBox.Text.Length == 0)
            {
                MessageBox.Show("Имя не может быть пустым");
            }
            else if (groupToAddTextBox.Text.Length == 0)
            {
                MessageBox.Show("Группа не может быть пустой");
            }
            if (courseToAddTextBox.Text.Length == 0 || !isGoodCourse)
            {
                MessageBox.Show("Курс не может быть пустым");
            }
            else if (gradeBookIDToAddTextBox.Text.Length == 0 || !isGoodBookId)
            {
                MessageBox.Show("Номер зачетки не может быть пустым");
            }
            else if (ratingToAddTextBox.Text.Length == 0 || !isGoodRating)
            {
                MessageBox.Show("Рейтинг не может быть пустым");
            }
            else if (courseToAdd < 1 || courseToAdd > 4)
            {
                MessageBox.Show("Пожалуйста, введите правильный курс(от 1 до 4)!");
            }
            else if (gradeBookIDToAdd < 1 || gradeBookIDToAdd > 100)
            {
                MessageBox.Show("Пожалуйста, введите правильный номер зачетки(от 1 до 100)!");
            }
            else if (ratingToAdd < 1 || ratingToAdd > 100)
            {
                MessageBox.Show("Пожалуйста, введите правильный рейтинг(от 1 до 100)!");
            }
            else
            {
                canContinue = true;
            }

            if (canContinue)
            {
                Student student = new Student();
                student.Surname = surnameToAdd;
                student.Name = nameToAdd;
                student.Group = groupToAdd;
                student.Course = courseToAdd;
                student.GradeBookID = gradeBookIDToAdd;
                student.Rating = ratingToAdd;
                student.Notes = notesToAdd;
                list.Add(student);
                File.Delete(@"res\students.xml");

                using (FileStream fstr = new FileStream(@"res\students.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fstr, list.ToArray());
                }

                Home_page main = this.Owner as Home_page;
                main.studentsTable.DataSource = list;
            }
            else
            {
                MessageBox.Show("Произошла ошибка!");
            }
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
        }

        private List<Student> GetStudents()
        {
            using (FileStream fs = new FileStream(@"res\students.xml", FileMode.OpenOrCreate))
            {
                newStudents = (Student[])formatter.Deserialize(fs);
            }

            var list = newStudents.Cast<Student>().ToList();
            return list;
        }

        private void surnameToAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-яА-Я]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void nameToAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-яА-Я]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void courseToAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void ratingToAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void courseToAddTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupToAddTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
