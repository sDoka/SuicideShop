using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseSql
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((tb1.Text == "Admin") || (tb1.Text == "admin")) && (tb2.Text == "admin"))
            {
                AdminPanel admin_page = new AdminPanel();
                this.Hide();
                admin_page.Show();
            }
            else
                MessageBox.Show("Ошибка авторизации");


        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main_page = new Form1();
            main_page.Show();
        }
    }
}
