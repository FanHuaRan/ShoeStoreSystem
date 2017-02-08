using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// StockCompany管理类
    /// 2017/02/07 fhr
    /// </summary>
    class StockCompanyManager : EntityBaseManager<StockCompany>, IEntityManager<StockCompany>
    {
        public StockCompany FindStockCompanyByName(string stockCompanyName)
        {
            StockCompany company = this.context.StockCompanys
                .Where(p => p.StockCompanyName == stockCompanyName)
                .FirstOrDefault();
            return company;
        }
        private StockCompanyManager()
            : base()
        {

        }
        private static StockCompanyManager instance = null;
        public static StockCompanyManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StockCompanyManager();
                }
                return instance;
            }
        }
    }
}
