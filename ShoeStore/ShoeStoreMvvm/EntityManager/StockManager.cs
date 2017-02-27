using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Stock管理类
    /// 2017/02/07 fhr
    /// </summary>
    class StockManager : EntityBaseManager<Stock>, IEntityManager<Stock>
    {
        public StockManager()
            : base()
        {

        }
    }
}
