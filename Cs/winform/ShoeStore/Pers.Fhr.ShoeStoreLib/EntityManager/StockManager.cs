using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    class StockManager : EntityBaseManager<Stock>, IEntityManager<Stock>
    {
        private StockManager()
            : base()
        {

        }
        private static StockManager instance = null;
        public static StockManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StockManager();
                }
                return instance;
            }
        }
    }
}
