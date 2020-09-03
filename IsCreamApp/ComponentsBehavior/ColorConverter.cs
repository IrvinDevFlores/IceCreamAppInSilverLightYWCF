using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace IsCreamApp.ComponentsBehavior
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var state = (bool)value;
            return state ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
