using System;
using System.Globalization;
using Xamarin.Forms;

namespace ToDoList
{
    public class BoolToColorConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return Color.ForestGreen;
            }
            return Color.Default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
