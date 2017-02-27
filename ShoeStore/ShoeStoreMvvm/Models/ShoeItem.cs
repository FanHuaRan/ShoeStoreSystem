using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    class ShoeItem
    {
        public Int64 ShoeItemId { get; set; }
        public Int64 ShoeId { get; set; }
        public byte IsSell { get; set; }
        public string Color { get; set; }
        public float Size { get; set; }
        public float? SellPrice { get; set; }
        public virtual Shoe Shoe { get; set; }
    }
}
