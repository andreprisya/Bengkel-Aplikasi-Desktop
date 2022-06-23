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
    /// Interaction logic for LatihanHal2.xaml
    /// </summary>
    public partial class LatihanHal2 : Window
    {
        public LatihanHal2(string nama, string lahir, string usia, string tinggi, string jk)
        {
            InitializeComponent();
            txtHasil.Text = "Halo " + nama + "!\nKamu lahir di " + lahir 
                + " ya?" + "\nUsia Kamu " + usia + "\nTinggi Badan Kamu " 
                + tinggi + "\nJenis Kelamin Kamu " + jk;
        }
    }
}
