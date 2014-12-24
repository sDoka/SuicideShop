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

        private void select_Seller(object sender, EventArgs e)// c кнопки ОК, выбор поставщика
        {
            ll3.Visible = false;//надпись про блокировку
            ll4.Visible = false;//надпись про пустой склад
            pb1.Visible = false;//картинка пустого склада
            linkLabel2.Visible = true;//надпись про товары этого поставщка
            button2.Visible = true;//кнопка блокировки
            unlock_producer.Visible = false;//кнопка разблокировки


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
          //если поставщик заблокирован, вывести уведомление
            string blackList = (ds1.Tables["Sellers"].Rows[cb1.SelectedIndex][3].ToString());//вытаскиваем значение ЧС
            if (blackList == "True")
            {
                ll3.Visible = true;
            }

            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Use SuicideShop exec allToys '"+ seller+"'", dataBaseConnection);
            dataAdapter.Fill(ds, "Shop");          
            dgw1.DataSource = ds.Tables["Shop"];

            //если нет товаров поставщика на складе, вывести уведомление
            if (ds.Tables["Shop"].Rows.Count == 0)
            {
                pb1.Visible = true;
                ll4.Visible = true;
                linkLabel2.Visible = false;
            }
            if (ll3.Visible == true)
            {
                button2.Visible = false;
                unlock_producer.Visible = true;
            }

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

        private void sellersForm_Load(object sender, EventArgs e)//загрузка формы, тут надо искать обновления датасета
        {
            this.Form2_Load(sender,e);
            SqlConnection dataBaseConnection = new SqlConnection(connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SuicideShop.dbo.Sellers", dataBaseConnection);

            dataAdapter.Fill(ds1, "Sellers");
           
            cb1.Items.Clear();
            //   dgwTest.DataSource = ds1.Tables["Sellers"];
            for ( int i = 0; i < ds1.Tables["Sellers"].Rows.Count; i++)
            {
                cb1.Items.Add(ds1.Tables["Sellers"].Rows[i][1].ToString());

            }
            cb1.Text = cb1.Items[0].ToString();

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.select_Seller(sender,e);//основной вариант
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSeller add_seller = new addSeller();
            add_seller.Show();
        }

        private void add2_blackList(object sender, EventArgs e)
        {
            Int32 seller = Convert.ToInt32(ds1.Tables["Sellers"].Rows[cb1.SelectedIndex][0].ToString());//вытаскиваем ид поставщика
            string sql = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            sql = ("Use SuicideShop exec toBlackList '" + seller + "'");//занести поставщика в ЧС  
            try
            {
                dataBaseConnection.Open();
                dataAdapter.InsertCommand = new SqlCommand(sql, dataBaseConnection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Поставщик заблокирован");
                ll3.Visible = true;
                //найти нормальный способ обновлять датасет без перезагрузки формы

                this.Hide();
                sellersForm sell = new sellersForm();
                sell.Show();
            }
            catch //(Exception ex)
            {
              //  MessageBox.Show(ex.ToString());
              MessageBox.Show("Упс, что то пошло не так в блокировке");
            }
            dataBaseConnection.Close();
        }

        private void unlock_producer_Click(object sender, EventArgs e)
        {
            Int32 seller = Convert.ToInt32(ds1.Tables["Sellers"].Rows[cb1.SelectedIndex][0].ToString());//вытаскиваем ид поставщика
            string sql = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            sql = ("Use SuicideShop exec BlackOut '" + seller + "'");//убрать поставщика из ЧС  
            try
            {
                dataBaseConnection.Open();
                dataAdapter.InsertCommand = new SqlCommand(sql, dataBaseConnection);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Поставщик разблокирован");
                ll3.Visible = true;
                //найти нормальный способ обновлять датасет без перезагрузки формы

                this.Hide();
                sellersForm sell = new sellersForm();
                sell.Show();
            }
            catch //(Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
                MessageBox.Show("Упс, что то пошло не так в блокировке");
            }
            dataBaseConnection.Close();
        }
    
    
    }
}
