﻿using System;
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
    class Stock
    {
        public Int64 StockId { get; set; }

        public Int32 StockCompanyId { get; set; }

        public DateTime StockTime { get; set; }

        public Int32 StockCount { get; set; }
    }
}
