using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Store管理类
    /// </summary>
    class StoreManager : EntityBaseManager<Store>, IEntityManager<Store>
    {
        private StoreManager()
            : base()
        {

        }
        private static StoreManager instance = null;
        public static StoreManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StoreManager();
                }
                return instance;
            }
        }
    }
}
