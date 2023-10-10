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

namespace tr_salon_korizhin4_2IS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
        private void PageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
        private void PageButton1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
        private void PageButton2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
        private void PageButton3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
        private void PageButton4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

    }
}
