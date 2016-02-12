using System;
using System.Collections.Generic;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
    public class DictionaryConverter : IValueConverter
	{
        public Dictionary<object, object> Dictionary { get; set; }

		#region IValueConverter implementation
		
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
            if(parameter != null && parameter is Dictionary<object, object>){
                this.Dictionary = parameter as Dictionary<object, object>;
            }
            if (this.Dictionary != null)
            {
                if (this.Dictionary.ContainsKey(value))
                {
                    value = this.Dictionary[value];
                }
            }
			return value;
		}
		
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(parameter != null && parameter is Dictionary<object, object>){
                this.Dictionary = parameter as Dictionary<object, object>;
            }
            if (this.Dictionary != null)
            {
                foreach (KeyValuePair<object, object> pair in this.Dictionary)
                {
                    if (value.Equals(pair.Value))
                    {
                        value = pair.Key;
                        break;
                    }
                }
            }
            return value;
		}
		
		#endregion
	}
}