using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Season管理类
    /// 2017/02/05 fhr
    /// </summary>
    class SeasonManager : EntityBaseManager<Season>, IEntityManager<Season>
    {
        private SeasonManager()
            : base()
        {

        }
        private static SeasonManager instance = null;
        public static SeasonManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SeasonManager();
                }
                return instance;
            }
        }
    }
}
