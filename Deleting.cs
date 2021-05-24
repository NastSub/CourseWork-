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
    public partial class Deleting : Form
    {
        public static int IDBookToDelete;
        public Student[] newStudents;
        public XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
        public Deleting()
        {
            InitializeComponent();
        }
        private void submitDeleteButton_Click(object sender, EventArgs e)
        {
            bool isGoodIDBook = int.TryParse(Delete.Text.Trim(), out IDBookToDelete);
            var list = GetStudents().Cast<Student>().ToList();
            bool isInList = false;
            foreach (Student s in list.ToArray())
            {
                if (s.GradeBookID.Equals(IDBookToDelete))
                {
                    list.Remove(s);
                    isInList = true;
                }
            }

            if (!isGoodIDBook)
            {
                MessageBox.Show("Пожалуйста, введите Id!");
            }
            else
            {
                if (isInList == false)
                {
                    MessageBox.Show("Пожалуйста, введите Id из списка!");
                }
            }

            File.Delete(@"res\students.xml");

            using (FileStream fstr = new FileStream(@"res\students.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fstr, list.ToArray());
            }

            Home_page main = this.Owner as Home_page;
            main.studentsTable.DataSource = list;
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            //if (isInList)
            //{
            //    Close();
            //}
        } 
        private void IDBookToDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void surnameDelete_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
