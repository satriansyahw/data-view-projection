using Intersoft.Crosslight.Data.ComponentModel;
using Intersoft.Crosslight.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

#if CORE
using Intersoft.Crosslight.Data;
#else
using System.ComponentModel.DataAnnotations.Schema;
#endif

namespace ViewProjectionSample.DomainModels
{
    public partial class SalesOrderHeader
    {
        [NotMapped]
        [Select("Address1.CompleteAddress")]
        public string ShipAddress { set; get; }

        [NotMapped]
        [Select("Customer.CompanyName")]
        public string CustomerCompany { set; get; }

        [NotMapped]
        [Select("SalesOrderDetails.OrderQty", Aggregate.Sum)]
        public int ProductQuantity { set; get; }

        [NotMapped]
        [Select("SalesOrderDetails", "OrderQty * UnitPrice * (1 - UnitPriceDiscount)", Aggregate.Sum)]
        public double SubTotal { set; get; }
    }
}
