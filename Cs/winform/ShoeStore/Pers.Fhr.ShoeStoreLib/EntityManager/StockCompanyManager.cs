using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    class StockCompanyManager : EntityBaseManager<StockCompany>, IEntityManager<StockCompany>
    {
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
