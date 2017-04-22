using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ShoeStoreMvvm.Converters
{
    /// <summary>
    /// 售卖状态转换器
    /// 2017/04/26 fhr
    /// </summary>
    [ValueConversion(typeof(byte), typeof(string))]
    class ShoeItemSellStateConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var byteValue=(byte)value;
            if (byteValue == 1)
            {
                return "已售";
            }
            else
            {
                return "未售";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var strValue =value.ToString();
            if (value == "已售")
            {
                return 1;
            }
            else if (value == "未售")
            {
                return 0;
            }
            else throw new ArgumentException("shoe type is illegale");
        }
    }
}
