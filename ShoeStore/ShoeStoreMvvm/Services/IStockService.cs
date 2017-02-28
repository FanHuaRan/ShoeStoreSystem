using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 进货服务
    /// </summary>
    public interface IStockService:IBaseEntityService<Stock>
    {
        /// <summary>
        /// 进货
        /// </summary>
        /// <returns></returns>
        Stock Stock(DateTime dateTime, string StockCompanyName,IList<Shoe> shoes);
    }
}
