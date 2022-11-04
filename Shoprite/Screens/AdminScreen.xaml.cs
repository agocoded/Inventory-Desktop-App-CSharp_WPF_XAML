using MySql.Data.MySqlClient;
using Shoprite.carts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shoprite.Screens
{
    /// <summary>
    /// Interaction logic for AdminScreen.xaml
    /// </summary>
    public partial class AdminScreen : Window
    {

        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public AdminScreen()
        {
            server = "localhost";
            database = "shoprite";
            uid = "root";
            password = "";

            String connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);


            /// initialisation starts here
            InitializeComponent();

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `users` WHERE `role`='admin' ";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                admins.Text = rows.ToString();
                conn.Close();

            }

            if (true)
            {

                string query = $"SELECT * FROM category";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                dataGrid.DataContext = dt;
            }

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `users` WHERE `role`='attendant' ";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                users.Text = rows.ToString();
                conn.Close();

            }

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `tills`";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                total_tills.Text = rows.ToString();
                conn.Close();

            }

            if (true)
            {
                string query = $"SELECT * FROM sales";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                sales.DataContext = dt;
            }



        }


        private void logback(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow shop = new MainWindow();
            shop.Show();
        }

        private void upd_toma(object sender, RoutedEventArgs e)
        {
            this.Hide();
            carts.Tomato home = new carts.Tomato();
            home.Show();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Screens.Shop home = new Screens.Shop();
            home.Show();
        }

        private void views(object sender, RoutedEventArgs e)
        {
            if (true)
            {

                string query = $"SELECT * FROM category";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                dataGrid.DataContext = dt;
            }

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `users` WHERE `role`='attendant' ";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                users.Text = rows.ToString();
                conn.Close();

            }

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `tills`";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                total_tills.Text = rows.ToString();
                conn.Close();

            }

            if (true)
            {
                string query = "SELECT COUNT(*) FROM `users` WHERE `role`='admin' ";
                conn.Open();
                MySqlCommand comman = new MySqlCommand(query, conn);
                int rows = Convert.ToInt32(comman.ExecuteScalar());
                admins.Text = rows.ToString();

                conn.Close();

            }

            

        }


        private void update(object sender, RoutedEventArgs e)
        {
            string type = typex.Text;
            string item = itemx.Text;
            int quantity = int.Parse(quatityx.Text);
            int price = int.Parse(pricex.Text);
            int amount = int.Parse(amountx.Text);
            int sold    = int.Parse(soldx.Text);
            int id = int.Parse(idx.Text);


            conn.Open();
            string query = $"UPDATE `category` SET `type`='{type}',`item`='{item}',`quantity`='{quantity}',`price`='{price}',`sold`='{sold}',`amount`='{amount}' WHERE `id`='{id}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show($"ID number {id} is UPDATED SUCCESSFULLY");
            conn.Close();


            typex.Text = "";
            itemx.Text = "";
            quatityx.Text= "";
            pricex.Text = "";
            amountx.Text = "";
            soldx.Text = "";
            idx.Text = "";
        }

        private void add(object sender, RoutedEventArgs e)
        {
            string type = typex.Text;
            string item = itemx.Text;
            int quantity = int.Parse(quatityx.Text);
            int price = int.Parse(pricex.Text);
            int amount = int.Parse(amountx.Text);
            int sold = int.Parse(soldx.Text);
            


            conn.Open();
            string query = $"INSERT INTO `category`(`id`, `type`, `item`, `quantity`, `price`, `sold`, `amount`) VALUES ('','{type}','{item}','{quantity}','{price}','{sold}','{amount}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show($"Added SUCCESSFULLY");
            conn.Close();


            typex.Text = "";
            itemx.Text = "";
            quatityx.Text = "";
            pricex.Text = "";
            amountx.Text = "";
            soldx.Text = "";
            idx.Text = "";
        }

        private void remove(object sender, RoutedEventArgs e)
        {
 
            ///
            int id = int.Parse(idx.Text);

            conn.Open();
            string query = $"DELETE FROM `category` WHERE `id` ='{id}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show($"ID number {id} DELETED SUCCESSFULLY");
            conn.Close();


            typex.Text = "";
            itemx.Text = "";
            quatityx.Text = "";
            pricex.Text = "";
            amountx.Text = "";
            soldx.Text = "";
            idx.Text = "";
        }

        private void view_sales(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM sales";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            sales.DataContext = dt;
        }

        private void gotoTill(object sender, RoutedEventArgs e)
        {
            this.Close();
            Tills home = new Tills();
            home.Show();
        }
    }
}
