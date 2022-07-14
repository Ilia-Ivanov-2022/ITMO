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

namespace ITMO.CSAppDev.WPF.Lab2.Exercise1.WpfRoutedEvent_2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by textBox");
            e.Handled = (bool)radBut1.IsChecked;
        }

        private void Grid_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by Grid");
            e.Handled = (bool)radBut2.IsChecked;
        }

        private void Window_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by Window");
            e.Handled = (bool)radBut3.IsChecked;
        }
    }
}
