using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTelegram.Converters
{
    public class WritedByContactToBackgroundConverter : BaseConverter<WritedByContactToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return (bool)value ? Application.Current.FindResource("Selected") : Application.Current.FindResource("MainColor");
            else
                return (bool)value ? Application.Current.FindResource("MainColor") : Application.Current.FindResource("Selected");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
