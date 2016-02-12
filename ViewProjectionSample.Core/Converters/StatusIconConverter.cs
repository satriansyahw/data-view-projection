using System;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
    public class StatusIconConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Status;
            byte[] result=null;
            if (Int32.TryParse(value.ToString(), out Status))
            {
                switch (Status)
                {
                    case 6:
                    case 4:
                        result = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(StatusIconConverter)).Assembly.GetManifestResourceStream("ViewProjectionSample.Assets.Images.Icons.ic_order_canceled.png").ToByte();
                        break;
                    case 5:
                        result = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(StatusIconConverter)).Assembly.GetManifestResourceStream("ViewProjectionSample.Assets.Images.Icons.ic_order_completed.png").ToByte();
                        break;
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

