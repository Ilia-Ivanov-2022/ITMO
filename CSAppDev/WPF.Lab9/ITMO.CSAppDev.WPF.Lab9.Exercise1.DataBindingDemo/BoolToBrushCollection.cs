using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ITMO.CSAppDev.WPF.Lab9.Exercise1.DataBindingDemo
{
    [ValueConversion(typeof(bool), typeof(Brush))]
    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture)
        {
            Brush b = null;
            if (value != null &&
            value.GetType() == typeof(bool))
            {
                b = (bool)value ? Brushes.Green : Brushes.Red;
            }
            return b;
        }
        public object ConvertBack(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture)
        {
            return null;
        }
    }
}