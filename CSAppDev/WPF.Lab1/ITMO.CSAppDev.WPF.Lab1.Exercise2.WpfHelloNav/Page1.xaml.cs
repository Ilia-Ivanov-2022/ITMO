
using System.Windows;
using System.Windows.Controls;

namespace ITMO.CSAppDev.WPF.Lab1.Exercise2.WpfHelloNav
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Page2 page = new Page2();
            this.NavigationService.Navigate(page);
        }
    }
}
