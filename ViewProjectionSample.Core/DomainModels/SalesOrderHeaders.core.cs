using Intersoft.Crosslight.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ViewProjectionSample.DomainModels
{
    public partial class SalesOrderHeader
    {
        [IgnoreDataMember]
        public double DaysLeft
        {
            get
            {
                return (this.DueDate - new DateTime(2015,6,1)).TotalDays;
            }
            set { }
        }

        [IgnoreDataMember]
        public double TotalDue
        {
            get
            {
                return (double)((decimal)this.SubTotal + this.TaxAmt + this.Freight);
            }
        }
    }
}
