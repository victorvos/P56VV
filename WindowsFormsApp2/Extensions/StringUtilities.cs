using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Extensions
{
    public static class CurrencyExtensions
    {
        public static string AsCurrency(this int value)
        {
            return value.AsCurrency(CultureInfo.CurrentCulture);
        }

        public static string AsCurrency(this int value, CultureInfo culture)
        {
            decimal result = value / 100m;
            return result.ToString("c", culture);
        }
    }
}
