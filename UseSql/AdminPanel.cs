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
    public partial class AdminPanel : Form
    {
        Form1 main_page = new Form1();
       
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void go_add(object sender, EventArgs e)
        {
            addItem add_page = new addItem();
            this.Hide();
            add_page.Show();
        }

        private void go_main(object sender, EventArgs e)
        {
            
            this.Hide();
            main_page.Show();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            main_page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellersForm sell = new sellersForm();
            this.Hide();
            sell.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            soldItems si = new soldItems();
            si.Show();
        }
    }
}
