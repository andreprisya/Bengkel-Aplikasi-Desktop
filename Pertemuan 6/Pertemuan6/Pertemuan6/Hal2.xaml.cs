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
    /// Interaction logic for Hal2.xaml
    /// </summary>
    public partial class Hal2 : Window
    {
        public Hal2(string nama, string ttl)
        {
            InitializeComponent();
            txtHasil.Text = "Halo " + nama + "!\nKamu lahir di " + ttl + " ya?";
        }
    }
}
