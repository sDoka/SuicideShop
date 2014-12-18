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

    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch //(Exception ex)
            {
                Application.ExitThread();
            }
        }

        private void  go_Change(object sender, EventArgs e)//не забудь поправить на страницу логина

        {
            AdminPanel login_page = new AdminPanel();
            this.Hide();
            login_page.Show();
        }
        private void go_menu(object sender, EventArgs e)//переход на страницу ассортимента
        {

            menuForm menu_page = new menuForm();
            this.Hide();
            menu_page.Show();
        }
 
    }
}
