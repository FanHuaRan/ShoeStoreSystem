using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    class Order
    {
        public Int64 OrderId { get; set; }
        public Int64? CustomerId { get; set; }
        public DateTime SaleTime { get; set; }
        public float TotalPrice { get; set; }
        public Int32 Count { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
