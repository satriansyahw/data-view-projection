using System;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
    public class StatusIconVisibilityConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Status;
            bool result = false;
            if (Int32.TryParse(value.ToString(), out Status))
            {
                result = Status >= 4;
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

