using MySql.Data.MySqlClient;
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

namespace Shoprite.carts
{
    /// <summary>
    /// Interaction logic for Tomato.xaml
    /// </summary>
    public partial class Tomato : Window
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Tomato()
        {
            server = "localhost";
            database = "shoprite";
            uid = "root";
            password = "";

            String connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            ///application starts from here 

            InitializeComponent();
        }

        private void logback(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow shop = new MainWindow();
            shop.Show();
        }

        private void goback(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Screens.Shop home = new Screens.Shop();
            home.Show();
        }

        private void view(object sender, RoutedEventArgs e)
        {
            this.Show();
        }

        private void update(object sender, RoutedEventArgs e)
        {
            string type = typex.Text;
            string item = itemx.Text;
            int quantity = int.Parse(quantityx.Text);
            string mode = modex.Text;
            int id = int.Parse(idx.Text);
            int price = int.Parse(pricex.Text);

            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy-MM-dd");

            /// INSERT INTO `sales`(`id`, `type`, `item`, `mode`, `quantity`, `price`, `date`) VALUES ('','Phone','13 pro max','cash','2','200','2022-08-23')

            conn.Open();
            string query = $"UPDATE `sales` SET `type`='{type}',`item`='{item}',`mode`='{mode}',`quantity`='{quantity}',`price`='{price}',`date`='{date}' WHERE `id`='{id}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show($"ID number {id} is UPDATED SUCCESSFULLY");
            conn.Close();


            typex.Text = "";
            itemx.Text = "";
            quantityx.Text = "";
            modex.Text = "";
            idx.Text = "";
        }

        private void back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Screens.Shop home = new Screens.Shop();
            home.Show();
        }

        private void check(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                string type = typex.Text;
                string item = itemx.Text;
                int quantity = int.Parse(quantityx.Text);
                string mode = modex.Text;
                int price = int.Parse(pricex.Text);

                DateTime now = DateTime.Now;
                string date = now.ToString("yyyy-MM-dd");


                conn.Open();
                string query = $"INSERT INTO `sales`(`id`, `type`, `item`, `mode`, `quantity`, `price`, `date`) VALUES ('','{type}','{item}','{mode}','{quantity}','{price}','{date}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int value = cmd.ExecuteNonQuery();
                MessageBox.Show($"Trasaction sale recorded successfully ");
                conn.Close();


                typex.Text = "";
                itemx.Text = "";
                quantityx.Text = "";
                modex.Text = "";
                pricex.Text = "";
            }


            if(true)
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

        private void refresh(object sender, RoutedEventArgs e)
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
}
