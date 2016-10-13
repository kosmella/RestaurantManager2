using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace RestaurantManager.Extensions
{
    public class BoolToColorConverter : IValueConverter
    {
        readonly Color expediteColor = Colors.Red;
        readonly Color notExpediteColor = Colors.Transparent;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color returnColor = Colors.Orange;
            if(value is bool)
            {
                
                returnColor = (bool)value ? expediteColor : notExpediteColor;
            }
            return new SolidColorBrush(returnColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
