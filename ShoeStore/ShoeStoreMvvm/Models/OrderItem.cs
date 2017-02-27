using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    class OrderItem
    {
        public Int64 OrderItemId { get; set; }

        public Int64 OrderId { get; set; }

        public Int64 ShoeItemId { get; set; }

        public float SellPrice { get; set; }

        public virtual Order Order { get; set; }

        public virtual ShoeItem ShoeItem { get; set; }
    }
}
