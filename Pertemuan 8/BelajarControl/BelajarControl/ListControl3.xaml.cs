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

namespace BelajarControl
{
    /// <summary>
    /// Interaction logic for ListControl3.xaml
    /// </summary>
    public partial class ListControl3 : Window
    {
        public ListControl3()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Judul = "Belajar Bengkel Aplikasi Desktop", Progres = 55 });
            items.Add(new TodoItem() { Judul = "Belajar WPF dengan C#", Progres = 70 });
            items.Add(new TodoItem() { Judul = "Membuat Laporan Praktikum", Progres = 0 });
            lbTodoList.ItemsSource = items;
        }

        public class TodoItem
        {
            public string Judul { get; set; }
            public int Progres { get; set; }
        }
    }
}
