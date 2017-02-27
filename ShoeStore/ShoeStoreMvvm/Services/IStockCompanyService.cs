using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services
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
