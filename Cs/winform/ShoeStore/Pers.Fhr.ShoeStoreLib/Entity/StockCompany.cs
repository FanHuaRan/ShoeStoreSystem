using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 进货商实体
    /// 2017/2/5 fhr
    /// </summary>
    class StockCompany
    {
        [PrimaryKeyAttribute]
        public Int32 StockCompanyId { get; set; }

        public string StockCompanyName { get; set; }

        public StockCompany(Int32 stockCompanyId, string stockCompanyName)
        {
            this.StockCompanyId = stockCompanyId;
            this.StockCompanyName = stockCompanyName;
        }
    }
}
