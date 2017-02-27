using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 存货信息
    /// 2017/2/5 fhr
    /// </summary>
   public class Store
    {
        public Int64 StoreId { get; set; }

        public Int64 ShoeId { get; set; }

        public Int32 RegionId { get; set; }

        public string MoreInfo { get; set; }

        public Store(Int64 storeId,Int64 shoeId,Int32 regionId,string more)
        {
            this.StoreId = storeId;
            this.ShoeId = shoeId;
            this.RegionId = regionId;
            this.MoreInfo = more;
        }
        public Store(Int64 shoeId,Int32 regionId,string more)
            : this(-1,shoeId,regionId,more)
        {

        }
    }
}
