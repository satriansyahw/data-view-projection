using Intersoft.Crosslight.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProjectionSample.DomainModels
{
    public partial class Address
    {

        public string CompleteAddress
        {
            get
            {
                string result = this.AddressLine1 + "\n";
                if (!String.IsNullOrWhiteSpace(this.City))
                {
                    result += this.City;
                    result += String.IsNullOrWhiteSpace(this.StateProvince) ? "" : ", " + this.StateProvince;
                }
                else
                {
                    result += String.IsNullOrWhiteSpace(this.StateProvince) ? "" : this.StateProvince;
                }

                return result;
            }
        }
    }
}
