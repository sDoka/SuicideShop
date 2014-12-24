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
    public partial class addItem : Form
    {
        AdminPanel main_page = new AdminPanel();
       static string connect = "Server=.\\SQLExpress;Database=SuicideShop;Trusted_Connection=Yes";
       SqlConnection dataBaseConnection = new SqlConnection(connect);
       DataSet ds1 = new DataSet();
       DataSet ds2 = new DataSet();

        public addItem()
        {
            InitializeComponent();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
            main_page.Show();
        }

        private void add_Items(object sender, EventArgs e)
        {
            Int32 seller = Convert.ToInt32(ds1.Tables["Sellers"].Rows[cb1.SelectedIndex][0].ToString());
          //  int a = cb1.SelectedIndex;
           string type = string.Join(",", clb1.CheckedItems.Cast<string>().ToArray());
            string sql = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            sql = ("Insert Into dbo.Shop" +
                "( Наименование, ID_Поставщик, Тип) Values ('"+tb1.Text.ToString()+"','"+seller+"','"+type+"');");//id поставщика  
            try 
            {
                dataBaseConnection.Open();
                dataAdapter.InsertCommand = new SqlCommand(sql, dataBaseConnection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Наименование добавлено");
            }
            catch //(Exception ex)
            {
               // MessageBox.Show(ex.ToString());
                MessageBox.Show("Возникли неполадки, возможно вы заполнили не все поля");
            }
            dataBaseConnection.Close();
        }

        private void addItem_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cb1, "В списке доступны только незаблокированные поставщики.");
           
            // забиваем комбобокс из датасета
           
            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SuicideShop.dbo.Sellers Where blackList = '0'", dataBaseConnection);

            dataAdapter.Fill(ds1, "Sellers");

            cb1.Items.Clear();
        //   dgwTest.DataSource = ds1.Tables["Sellers"];
            for (int i = 0; i < ds1.Tables["Sellers"].Rows.Count; i++)
            {
                cb1.Items.Add(ds1.Tables["Sellers"].Rows[i][1].ToString());
               
            }
            cb1.Text = cb1.Items[0].ToString();

          

            //надо щас акже забить чекбокс
            dataAdapter = new SqlDataAdapter("SELECT * FROM SuicideShop.dbo.sTypes", dataBaseConnection);

            dataAdapter.Fill(ds2, "sTypes");

            clb1.Items.Clear();
            //     dgwTest.DataSource = ds.Tables["Sellers"];
            for (int i = 0; i < ds2.Tables["sTypes"].Rows.Count; i++)
            {
                clb1.Items.Add(ds2.Tables["sTypes"].Rows[i][1].ToString());
            }
            clb1.Text = clb1.Items[0].ToString();


        }

        private void addItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            main_page.Show();
        }
       
        }
    }

