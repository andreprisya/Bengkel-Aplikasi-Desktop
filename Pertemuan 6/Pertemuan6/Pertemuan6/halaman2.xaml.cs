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
    /// Interaction logic for halaman2.xaml
    /// </summary>
    public partial class halaman2 : Window
    {
        public halaman2()
        {
            InitializeComponent();
        }

        private void btnKedua_Klik(object sender, RoutedEventArgs e)
        {
            halaman1 hal1 = new halaman1();
            hal1.Show();
            this.Close();
        }
    }
}
