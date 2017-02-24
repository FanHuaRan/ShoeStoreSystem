using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 进货商服务
    /// </summary>
    public interface IStockCompanyService : IBaseEntityService<StockCompany>
    {
        StockCompany PutIfAbsent(string stockCompanyName);
        StockCompany FindStockCompanyByName(string stockCompanyName);
    }
}
