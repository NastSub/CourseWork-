using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace students
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[a-z]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[a-z]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length != 0 && passwordTextBox.Text.Length != 0 && loginTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("admin"))
            {
                Home_page form2 = new Home_page();
                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
