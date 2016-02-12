using System;
using System.Collections.Generic;
using System.Globalization;
using Intersoft.Crosslight;

namespace ViewProjectionSample
{
    public class StatusLabelConverter : DictionaryConverter
	{
        #region Constructor
        public StatusLabelConverter()
        {
            this.Dictionary = new Dictionary<object, object>(){
                {(byte)1, "IN PROGRESS"},
                {(byte)2, "APPROVED"},
                {(byte)3, "BACK ORDERED"},
                {(byte)4, "REJECTED"},
                {(byte)5, "SHIPPED"},
                {(byte)6, "CANCELED"}
            };
        }
        #endregion
	}
}

