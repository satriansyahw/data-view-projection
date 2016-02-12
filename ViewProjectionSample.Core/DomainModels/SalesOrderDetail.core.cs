using Intersoft.Crosslight.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProjectionSample.DomainModels
{
    public partial class SalesOrderDetail
    {
        public string SummaryInfo
        {
            get
            {
                return String.Format("Quantity : {0} unit     Line Total : {1:c2}", this.OrderQty, (this.OrderQty * this.UnitPrice * (1 - this.UnitPriceDiscount)));
            }
        }
    }
}
