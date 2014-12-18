using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseSql
{
    public partial class addSeller : Form
    {
        static string connect = "Server=.\\SQLExpress;Database=SuicideShop;Trusted_Connection=Yes";
        DataSet ds = new DataSet();
        SqlConnection dataBaseConnection = new SqlConnection(connect);
        public addSeller()
        {
            InitializeComponent();
        }

        private void add_seller(object sender, EventArgs e)
        {
            string sql = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            sql = ("Insert Into dbo.Sellers" +
                "( Поставщик, Страна) Values ('" + tb1.Text.ToString() + "','" + tb2.Text.ToString() + "');");//строка на инсерт поставщика
            try
            {
                dataBaseConnection.Open();
                dataAdapter.InsertCommand = new SqlCommand(sql, dataBaseConnection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Поставщик добавлен");
            }
            catch //(Exception ex)
            {
                // MessageBox.Show(ex.ToString());
                MessageBox.Show("УУУпс, что то пошло не так =(");
            }
        }

        private void addSeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            sellersForm sellers = new sellersForm();
            sellers.Show();
        }
    }
}
