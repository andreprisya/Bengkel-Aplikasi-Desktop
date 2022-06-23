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
    /// Interaction logic for LatihanNavigasi1.xaml
    /// </summary>
    public partial class LatihanNavigasi1 : Window
    {
        public LatihanNavigasi1()
        {
            InitializeComponent();
        }

        private void BtnKlik_Click(object sender, RoutedEventArgs e)
        {
            string nama = txtNama.Text;
            string lahir = txtLahir.Text;
            string usia = txtUsia.Text;
            string tinggi = txtTinggi.Text;
            string jk = null;

            if(jk_LK.IsChecked == true)
            {
                jk = "Laki-Laki";
            } else if(jk_PR.IsChecked == true){
                jk = "Perempuan";
            }

            LatihanHal2 hal = new LatihanHal2(nama, lahir, usia, tinggi, jk);
            hal.Show();

        }
    }
}
