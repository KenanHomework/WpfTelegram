using System;
using System.Windows;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTelegram.Converters
{
    public class WritedByContactToForegroundConverter : BaseConverter<WritedByContactToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return (bool)value ? Application.Current.FindResource("MainColor") : Application.Current.FindResource("Secondary");
            else
                return (bool)value ? Application.Current.FindResource("Secondary") : Application.Current.FindResource("MainColor");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
