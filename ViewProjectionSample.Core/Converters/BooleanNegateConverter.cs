using System;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
	public class BooleanNegateConverter : IValueConverter
	{
		#region IValueConverter implementation
		
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
				return !(bool)value;

			return value;
		}
		
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		
		#endregion
	}
}

