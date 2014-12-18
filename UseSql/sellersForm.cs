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
    public partial class sellersForm : Form
    {

        static string connect = "Server=.\\SQLExpress;Database=SuicideShop;Trusted_Connection=Yes";
        SqlConnection dataBaseConnection = new SqlConnection(connect);
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds = new DataSet();
        AdminPanel admin_page = new AdminPanel();
        public sellersForm()
        {
            InitializeComponent();
        }










        private void form_Wider()//альтернативная анимация изменения формы. активная
        {
            for (int i = this.Width; this.Width < 580; i++)
            {
                this.Width = this.Width + 5;
                this.Refresh();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(243, 236);
            this.DoubleBuffered = true;
        }

        private void select_Seller(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                dgw1.Update();

            }
            catch //(Exception ex)
            {
                MessageBox.Show("..!.");
            }           
            this.form_Wider();
            //сделать выборку по id_поставщика
            Int32 seller = Convert.ToInt32(ds1.Tables["Sellers"].Rows[cb1.SelectedIndex][0].ToString());//вытаскиваем ид поставщика
          

            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Use SuicideShop exec allToys '"+ seller+"'", dataBaseConnection);
            dataAdapter.Fill(ds, "Shop");          
            dgw1.DataSource = ds.Tables["Shop"];

        }

        private void sellersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin_page.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Run4Fun f4f = new Run4Fun();
            f4f.Show();
            this.Hide();
        }

        private void sellersForm_Load(object sender, EventArgs e)
        {
            this.Form2_Load(sender,e);
            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SuicideShop.dbo.Sellers", dataBaseConnection);

            dataAdapter.Fill(ds1, "Sellers");

            cb1.Items.Clear();
            //   dgwTest.DataSource = ds1.Tables["Sellers"];
            for (int i = 0; i < ds1.Tables["Sellers"].Rows.Count; i++)
            {
                cb1.Items.Add(ds1.Tables["Sellers"].Rows[i][1].ToString());

            }
            cb1.Text = cb1.Items[0].ToString();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSeller add_seller = new addSeller();
            add_seller.Show();
        }
    
    
    }
}
