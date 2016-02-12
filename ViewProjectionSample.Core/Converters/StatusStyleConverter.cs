using System;
using System.Collections.Generic;
using System.Globalization;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Drawing;
using ViewProjectionSample.DomainModels;

namespace ViewProjectionSample
{
    public class StatusStyleConverter : DictionaryConverter
	{
        #region Constructor
        public StatusStyleConverter()
        {
            this.Dictionary = new Dictionary<object, object>(){
                {(byte)1, new StyleAttributes() { BackgroundColor = Color.FromHex("FF81D4FA") }},
                {(byte)2, new StyleAttributes() { BackgroundColor = Color.FromHex("FF2196F3") }},
                {(byte)3, new StyleAttributes() { BackgroundColor = Color.FromHex("FFFF9800") }},
                {(byte)4, new StyleAttributes() { BackgroundColor = Color.FromHex("FFF44336") }},
                {(byte)5, new StyleAttributes() { BackgroundColor = Color.FromHex("FF64DD17") }},
                {(byte)6, new StyleAttributes() { BackgroundColor = Colors.Gray }}
            };
        }
        #endregion
	}
}

