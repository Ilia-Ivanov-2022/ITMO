using System;
using System.Windows;

namespace ITMO.CSAppDev.WPF.Lab1.Exercise1.WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.IsEnabled = false;
            button1.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdSNButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("C://Temp/username.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
                button1.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRTButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("C://Temp/username.txt");
                label.Content = "Greeting You, dear " + sr.ReadToEnd() + "!";
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            button.IsEnabled=true;
        }
    }
}
