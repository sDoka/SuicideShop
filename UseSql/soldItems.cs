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
    public partial class soldItems : Form
    {
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
      static  string connect = "Server=.\\SQLExpress;Database=SuicideShop;Trusted_Connection=Yes";
        SqlConnection dataBaseConnection = new SqlConnection(connect);
        public soldItems()
        {
            InitializeComponent();
        }

        private void sold_items_Load(object sender, EventArgs e)//отображает проданные товары при загрузке формы
        {
            final_sell_button.Visible = false;
            try
            {
                SqlConnection dataBaseConnection = new SqlConnection(connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT   sItems.Наименование, Sellers.Поставщик, sItems.Тип "
                    + " FROM Sellers INNER JOIN sItems ON Sellers.ID = sItems.ID_Поставщик ", dataBaseConnection);
                //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
                dataAdapter.Fill(ds, "sItems");
                //Здесь указываешь имя нужной таблицы            
                dgw1.DataSource = ds.Tables["sItems"];
            }

            catch //(Exception ex)
            {
               // MessageBox.Show(ex.ToString());
                MessageBox.Show("Упс, что то пошло не так =((");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void soldItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void new_sell(object sender, EventArgs e)// переходим на таблицу текущих товаров, выбираем строку, удаляем, переходим обратно к проданным
        {//ll1 - проданные товары. ll2 - товары в наличии
            ll2.Visible = true;
            ll1.Visible = false;
            final_sell_button.Visible = true;
            sell_button.Visible = false;
            try
            {

                ds.Clear();
                dgw1.Update();
                SqlConnection dataBaseConnection = new SqlConnection(connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT   Shop.Наименование, Sellers.Поставщик, Shop.Тип "
                    + " FROM Sellers INNER JOIN Shop ON Sellers.ID = Shop.ID_Поставщик ", dataBaseConnection);
                //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
                dataAdapter.Fill(ds, "Shop");
                //Здесь указываешь имя нужной таблицы            
                dgw1.DataSource = ds.Tables["Shop"];
            }

            catch //(Exception ex)
            {
                // MessageBox.Show(ex.ToString());
                MessageBox.Show("Упс, что то пошло не так =((");
            }



        }

        private void final_sell_button_Click(object sender, EventArgs e)
        {
            dgw1.DataSource = ds.Tables["Shop"];
            dgw1.Update();
          
            //Получаем ИД товара через датасет и гридвью
            try
            {
                SqlConnection dataBaseConnection = new SqlConnection(connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SuicideShop.dbo.Shop", dataBaseConnection);

                dataAdapter.Fill(ds1, "Shop");
                
                
                
                // датасет.таблица.[номерСтроки].[номер столбца] 
                 Int32 for_sell = Convert.ToInt32(ds1.Tables["Shop"].Rows[dgw1.CurrentRow.Index][0]);//получили ID товара на удаление
                 string sql = null;

                 sql = ("USE SuicideShop EXEC sellToy '" + for_sell + "'");//id товара 
                 try
                 {
                     dataBaseConnection.Open();
                     dataAdapter.InsertCommand = new SqlCommand(sql, dataBaseConnection);
                     dataAdapter.InsertCommand.ExecuteNonQuery();
                     MessageBox.Show("Продажа товара успешно зарегистрирована");
                 }
                 catch //(Exception ex)
                 {
                     // MessageBox.Show(ex.ToString());
                     MessageBox.Show("Упс, что то пошло не так =((");
                 }
                 dataBaseConnection.Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


           
           


            //возвращаем видимость предыдуим компонентам
            ll1.Visible = true;
            ll2.Visible = false;
            final_sell_button.Visible = false;
            sell_button.Visible = true;
            final_sell_button.Visible = false;
            try
            {
                SqlConnection dataBaseConnection = new SqlConnection(connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT   sItems.Наименование, Sellers.Поставщик, sItems.Тип "
                    + " FROM Sellers INNER JOIN sItems ON Sellers.ID = sItems.ID_Поставщик ", dataBaseConnection);
                //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
                dataAdapter.Fill(ds, "sItems");
                //Здесь указываешь имя нужной таблицы            
                dgw1.DataSource = ds.Tables["sItems"];
            }

            catch //(Exception ex)
            {
                // MessageBox.Show(ex.ToString());
                MessageBox.Show("Упс, что то пошло не так =((");
            }

        }
    
    }
}
