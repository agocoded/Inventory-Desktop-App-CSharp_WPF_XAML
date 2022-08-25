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

namespace Shoprite.carts
{
    /// <summary>
    /// Interaction logic for Tomato.xaml
    /// </summary>
    public partial class Tomato : Window
    {
        public Tomato()
        {
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
    }
}
