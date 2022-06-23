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
    /// Interaction logic for BelajarWebCommand.xaml
    /// </summary>
    public partial class BelajarWebCommand : Window
    {
        public BelajarWebCommand()
        {
            InitializeComponent();
            ContohWeb.Navigate("https://www.google.com/");
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ContohWeb.Navigate(txtUrl.Text);
        }

        private void ContohWeb_Nav(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            txtUrl.Text = e.Uri.OriginalString;
        }

        private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((ContohWeb != null) && (ContohWeb.CanGoBack));
        }

        private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ContohWeb.GoBack();
        }

        private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((ContohWeb != null) && (ContohWeb.CanGoForward));
        }

        private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ContohWeb.GoForward();
        }

        private void GoToPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ContohWeb.Navigate(txtUrl.Text);
        }
    }
}
