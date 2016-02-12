using System;
using System.Globalization;
using Intersoft.Crosslight;
using ViewProjectionSample.DomainModels;

namespace ViewProjectionSample
{
    public class DayLeftLabelConverter : IValueConverter
	{
		#region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = "";
            if (value is SalesOrderHeader)
            {
                SalesOrderHeader SalesOrder = value as SalesOrderHeader;
                if (SalesOrder.Status < 4)
                {
                    result = SalesOrder.DaysLeft.ToString() + "d";
                }
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }

		#endregion
	}
}

