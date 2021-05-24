using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace students
{
    public partial class Home_page : Form
    {
        public XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
        public Student[] newStudents;
        public Home_page()
        {
            InitializeComponent();
        }

        public List<Student> GetStudents()
        {
            using (FileStream fs = new FileStream(@"res\students.xml", FileMode.OpenOrCreate))
            {
                newStudents = (Student[])formatter.Deserialize(fs);
            }
            var list = newStudents.Cast<Student>().ToList();
            return list;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studentsTable.DataSource = GetStudents();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Adding form5 = new Adding();
            form5.Owner = this;
            form5.Show();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            Deleting form4 = new Deleting();
            form4.Owner = this;
            form4.Show();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            Search form6 = new Search();
            form6.Owner = this;
            form6.Show();
        }
        private void sortAscendButton_Click(object sender, EventArgs e)
        {
            var sortedStudents = GetStudents().OrderBy(s => s.Surname).Cast<Student>().ToList(); ;
            studentsTable.DataSource = null;
            studentsTable.DataSource = sortedStudents;
        }

        private void sortDescendButton_Click(object sender, EventArgs e)
        {
            var sortedStudents = GetStudents().OrderByDescending(s => s.Surname).Cast<Student>().ToList(); ;
            studentsTable.DataSource = null;
            studentsTable.DataSource = sortedStudents;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var sortedStudents = GetStudents().OrderBy(s => s.Rating).Cast<Student>().ToList(); ;
            studentsTable.DataSource = null;
            studentsTable.DataSource = sortedStudents;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sortedStudents = GetStudents().OrderByDescending(s => s.Rating).Cast<Student>().ToList(); ;
            studentsTable.DataSource = null;
            studentsTable.DataSource = sortedStudents;
        }

        private void studentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
