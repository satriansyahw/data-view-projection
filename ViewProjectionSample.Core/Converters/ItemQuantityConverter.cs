using System;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
    public class ItemQuantityConverter : IValueConverter
	{
		#region IValueConverter implementation
		
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
		    if (value is int)
            {
                int? Quantity = value as int?;
                string result;
                if (Quantity > 1)
                {
                    result = Quantity.ToString() + " items";
                }
                else
                {
                    result = Quantity.ToString() + " item";
                }
                return result;
            }
			return value;
		}
		
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		
		#endregion
	}
}

