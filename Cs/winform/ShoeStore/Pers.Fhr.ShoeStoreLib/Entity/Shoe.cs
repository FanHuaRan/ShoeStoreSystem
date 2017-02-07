using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 鞋信息
    /// 2017/2/5 fhr
    /// </summary>
    class Shoe
    {
        [PrimaryKeyAttribute]
        public Int64 ShoeId { get; set; }

        public Int32 SeasonId { get; set; }

        public Int64? SaleId { get; set; }
        public Int64? StockId { get; set; }

        public Int32 ThingId { get; set; }

        public string Color { get; set; }

        public float Size { get; set; }

        public float Price { get; set; }

        public byte IsSell { get; set; }

        public float OriginMoney { get; set; }

        public byte Gender { get; set; }

        public float? SellPrice { get; set; }

        public Stock Stock{get;set;}

        public Sale Sale { get; set; }
    }
}
