using Pers.Fhr.ShoeStoreLib.Entity;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 供货商基本服务
    /// </summary>
    class StockCompanyService
        :AbstractEntityBaseClass<StockCompany,StockCompanyService>
        ,IStockCompanyService
    {
    //      
        public StockCompanyService(StockCompanyManager stockCompanyManager)
        {
            this.entityManager = stockCompanyManager;
        }
        public StockCompany PutIfAbsent(string stockCompanyName)
        {
            StockCompany company = FindStockCompanyByName(stockCompanyName);
            if (company == null)
            {
                StockCompany tempCompany = new StockCompany(-1, stockCompanyName);
                company = this.entityManager.Insert(company);
            }
            return company;
        }

        public StockCompany FindStockCompanyByName(string stockCompanyName)
        {
            StockCompanyManager stockCompanyManager = entityManager as StockCompanyManager;
            return stockCompanyManager.FindStockCompanyByName(stockCompanyName);
           
        }
    }
}
