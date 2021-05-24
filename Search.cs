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
    public partial class Search : Form
    {
        public static int search;
        public Home_page form = new Home_page();
        public XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //----
            //search = Convert.ToInt32(Search_TextBox.Text.Trim());
            bool isGoodSearch = int.TryParse(Search_TextBox.Text.Trim(), out search);
            var studentList = form.GetStudents();
            bool isInList = false;
            List<Student> newStudentList = new List<Student>();


            if (!isGoodSearch)
            {
                MessageBox.Show("Введите данные для поиска студента");
            }
            else
            {
                foreach (Student p in studentList.ToArray())
                {
                    if (search.Equals(p.GradeBookID))
                    {
                        newStudentList.Add(p);
                        isInList = true;
                    }
                }

                if (!isInList)
                {
                    MessageBox.Show("Такого студента нет в списке");
                }
                else
                {
                    Home_page main = this.Owner as Home_page;
                    main.studentsTable.DataSource = newStudentList;
                    foreach (var ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }
                    }
                    
                }
                
            }

        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
