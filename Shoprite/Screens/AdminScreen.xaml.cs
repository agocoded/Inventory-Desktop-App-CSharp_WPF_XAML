using System;
using System.Collections.Generic;
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
        public AdminScreen()
        {
            InitializeComponent();
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
    }
}
