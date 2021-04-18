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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListView
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Osoba.InitOsoby();
            LVOsoby.DataContext = Osoba.Osoby;
        }

        private void LVOsoby_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Osoba o = ((KeyValuePair<string, Osoba>)(sender as System.Windows.Controls.ListView).SelectedItem).Value;
            DataContext = o;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LVOsoby.SelectedIndex = 0;
        }
    }
}
