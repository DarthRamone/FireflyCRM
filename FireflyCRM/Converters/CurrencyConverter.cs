using System;
using System.Globalization;
using Xamarin.Forms;

namespace FireflyCRM.Converters
{
  public class CurrencyConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return decimal.Parse(value.ToString()).ToString("C");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}