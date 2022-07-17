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

namespace ITMO.CSAppDev.WPF.Lab4.Exercise3.UserIn3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        //    foreach (FontFamily F in Fonts.SystemFontFamilies)
        //    {
        //        comboBox1.Items.Add(F.ToString());
        //    }
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        ValueChanged:
            try
            {
                richTextBox1.Selection.ApplyPropertyValue(FontSizeProperty, Slider1.Value.ToString());
            }
            catch { }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontFamilyProperty, ((ListBoxItem)listBox1.SelectedItem).FontFamily);
        }
    }
}
