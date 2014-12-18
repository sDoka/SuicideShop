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
    public partial class Run4Fun : Form
    {
        public Run4Fun()
        {
            InitializeComponent();
        }

        private void Run4Fun_FormClosing(object sender, FormClosingEventArgs e)
        {
            sellersForm sell = new sellersForm();
            sell.Show();
        }
    }
}
