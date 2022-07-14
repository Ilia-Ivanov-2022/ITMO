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

namespace ITMO.CSAppDev.WPF.Lab2.Exercise1.WpfRoutedEvent_2_2
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

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            double a = Double.Parse(txtBox.Text);

            switch (feSource.Name)
            {
                case "butAdd":
                    a += a;
                    break;
                case "butMult":
                    a *= a;
                    break;
            }
            e.Handled = true;

            txtBox.Text = String.Format("{0:#.##}", a);
        }
    }
}
