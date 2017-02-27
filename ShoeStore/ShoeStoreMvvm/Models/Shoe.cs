using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 鞋信息
    /// 2017/2/5 fhr
    /// </summary>
   public class Shoe
    {
        [PrimaryKeyAttribute]
        public Int64 ShoeId { get; set; }
        public Int64 SeasonId { get; set; }
        public Int64 StockId { get; set; }
        public Int32 ThingId { get; set; }
        //成本价
        public float OriginMoney { get; set; }
        //零售价
        public float Price { get; set; }
        public byte Gender { get; set; }
        public virtual Stock Stock{get;set;}
        public virtual Season Season { get; set; }
    }
}
