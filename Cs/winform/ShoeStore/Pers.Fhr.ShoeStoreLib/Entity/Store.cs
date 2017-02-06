using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 存货信息
    /// 2017/2/5 fhr
    /// </summary>
    class Store
    {
        public Int64 StoreId { get; set; }

        public Int64 ShoeId { get; set; }

        public Int32 RegionId { get; set; }

        public string MoreInfo { get; set; }
    }
}
