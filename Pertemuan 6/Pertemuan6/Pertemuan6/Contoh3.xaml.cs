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
    /// Interaction logic for Contoh3.xaml
    /// </summary>
    public partial class Contoh3 : Window
    {
        public Contoh3()
        {
            InitializeComponent();
        }

        private void BtnKlik_Click(object sender, RoutedEventArgs e)
        {
            string nama = txtNama.Text;
            string ttl = txtLahir.Text;
            Hal2 hal = new Hal2(nama, ttl);
            hal.Show();
        }
    }
}
