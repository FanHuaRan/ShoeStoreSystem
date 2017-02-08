using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 销售信息
    /// 2017/2/5 fhr
    /// </summary>
   public class Sale
    {
        [PrimaryKeyAttribute]
        public Int64 SaleId { get; set; }

        public Int64? CustomerId { get; set; }


        public DateTime SaleTime { get; set; }

        public float TotalPrice { get; set; }

        public Customer Customer { get; set; }

        public Sale(Int64 saleId, Int64? customerId,DateTime saleTime, float totalPrice)
        {
            this.SaleId = saleId;
            this.CustomerId = customerId;
            this.SaleTime = saleTime;
            this.TotalPrice = totalPrice;
        }
        public Sale(Int64? customerId,DateTime saleTime, float totalPrice)
            : this(-1, customerId, saleTime, totalPrice)
        {

        }
    }
}
