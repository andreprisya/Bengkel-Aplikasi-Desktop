﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BelajarControl
{
    /// <summary>
    /// Interaction logic for ComboBoxControl2.xaml
    /// </summary>
    public partial class ComboBoxControl2 : Window
    {
        public ComboBoxControl2()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedIndex > 0)
                cmbColors.SelectedIndex = cmbColors.SelectedIndex - 1;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedIndex < cmbColors.Items.Count - 1)
                cmbColors.SelectedIndex = cmbColors.SelectedIndex + 1;
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            cmbColors.SelectedItem = typeof(Colors).GetProperty("Yellow");
        }

        private void cmbColors_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(null, null);
            this.Background = new SolidColorBrush(selectedColor);
        }
    }
}
