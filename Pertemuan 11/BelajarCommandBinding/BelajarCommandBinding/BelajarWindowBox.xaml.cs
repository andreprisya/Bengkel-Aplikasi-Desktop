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

namespace BelajarCommandBinding
{
    /// <summary>
    /// Interaction logic for BelajarWindowBox.xaml
    /// </summary>
    public partial class BelajarWindowBox : Window
    {
        public BelajarWindowBox()
        {
            InitializeComponent();
        }

        private void BtnSederhana_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Halo Teman!");
        }

        private void BtnJudul_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Halo teman TI!", "BelajarMessageBox");
        }

        private void BtnTombol_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MessageBox ini memberikan beberapa pilihan.\n\nHali Teman TI.", "BelajarMessageBox", MessageBoxButton.YesNoCancel);
        }

        private void BtnRespon_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Halo Teman TI, apa kabar? \"Halo TI\"?", "BelajarMessageBox", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Baik dong!", "BelajarMessageBox");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Luar biasa selalu!", "BelajarMessageBox");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Biasa aja ga spesial", "BelajarMessageBox");
                    break;
            }
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Halo teman", "BelajarMessageBox", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnPilihan_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Halo teman", "BelajarMessageBox", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}
