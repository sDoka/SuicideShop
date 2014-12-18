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
    
    public partial class menuForm : Form
    {
        Form1 main = new Form1();
      
       
        string connect = "Server=.\\SQLExpress;Database=SuicideShop;Trusted_Connection=Yes";
        public menuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            main.Show();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT   Shop.Наименование, Sellers.Поставщик, Shop.Тип "
                +" FROM Sellers INNER JOIN Shop ON Sellers.ID = Shop.ID_Поставщик ", dataBaseConnection);
            //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
            dataAdapter.Fill(ds, "Shop");
            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds.Tables["Shop"]; 

        }

        private void menuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            main.Show();
        }

        private void menuForm_Leave(object sender, EventArgs e)//////////////////////////ненужное
        {
        }
    }
}
