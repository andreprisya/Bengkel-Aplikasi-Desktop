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

namespace Pertemuan6
{
    /// <summary>
    /// Interaction logic for Contoh1.xaml
    /// </summary>
    public partial class Contoh1 : Window
    {
        public Contoh1()
        {
            InitializeComponent();
        }

        private void BtnKlikP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void BtnKlikP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
    }
}
