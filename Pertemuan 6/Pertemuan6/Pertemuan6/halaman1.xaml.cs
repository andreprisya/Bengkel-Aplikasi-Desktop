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
    /// Interaction logic for halaman1.xaml
    /// </summary>
    public partial class halaman1 : Window
    {
        public halaman1()
        {
            InitializeComponent();
        }

        private void btnPertama_Klik(object sender, RoutedEventArgs e)
        {
            halaman2 hal2 = new halaman2();
            hal2.Show();
            this.Close();
        }
    }
}
