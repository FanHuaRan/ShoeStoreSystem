using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ShoeStoreMvvm.Converters
{
    /// <summary>
    /// 性别转换器
    /// 2016/2/4 fhr
    /// </summary>
    [ValueConversion(typeof(byte), typeof(string))]
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var byteValue = (byte)value;
            switch (byteValue)
            {
                case 0 :return "通用";
                case 1: return "男";
                case 2: return "女";
                default:
                    return "未知";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var strValue = (string)value;
            switch (strValue)
            {
                case "通用": return 0;
                case "男": return 1;
                case "女": return 2;
                default:
                    return "3";
            }
        }
    }
}
