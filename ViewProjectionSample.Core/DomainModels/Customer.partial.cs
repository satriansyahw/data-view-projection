using Intersoft.Crosslight;
using Intersoft.Crosslight.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewProjectionSample.DomainModels
{
    partial class Customer
    {
        public string FullName {
            get {
                var name = this.FirstName;
                if (!String.IsNullOrWhiteSpace(this.MiddleName))
                    name += " "+ this.MiddleName;
                if (!String.IsNullOrWhiteSpace(this.LastName))
                    name += " "+ this.LastName;
                return name;
            }
        }
    }
}
