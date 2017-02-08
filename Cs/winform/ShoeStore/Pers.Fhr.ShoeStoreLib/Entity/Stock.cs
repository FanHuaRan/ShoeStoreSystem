using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 进货
    /// 2017/2/5 fhr
    /// </summary>
    public class Stock
    {
        public Int64 StockId { get; set; }

        public Int32 StockCompanyId { get; set; }

        public DateTime StockTime { get; set; }

        public Int32 StockCount { get; set; }

        public Stock(Int64 stockId, Int32 stockCompanyId, DateTime stockTime, Int32 stockCount)
        {
            this.StockId = stockId;
            this.StockCompanyId = stockCompanyId;
            this.StockTime = stockTime;
            this.StockCount = stockCount;
        }
        public Stock(Int32 stockCompanyId, DateTime stockTime, Int32 stockCount)
            : this(-1, stockCompanyId, stockTime, stockCount)
        {

        }
    }
}
