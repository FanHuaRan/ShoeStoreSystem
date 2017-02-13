using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Sale管理类
    /// 2017/02/05 fhr
    /// </summary>
    class SaleManager : EntityBaseManager<Sale>, IEntityManager<Sale>
    {
        public IList<Sale> FindSalesByTimeIntervel(DateTime? minTime,DateTime? maxTime)
        {
            if (minTime == null && maxTime == null)
            {
                return null;
            }
            if (minTime != null & maxTime == null)
            {
                return context.Sales.
                    Where(p => p.SaleTime >= minTime).ToList()
                    as List<Sale>;
            }
            if (minTime == null & maxTime != null)
            {
                return context.Sales.
                    Where(p => p.SaleTime <= maxTime).ToList()
                    as List<Sale>;
            }
            return context.Sales.
                    Where(p => p.SaleTime <= maxTime && p.SaleTime>=minTime).ToList()
                    as List<Sale>;
        }
        public SaleManager()
            : base()
        {
            
        }
     
    }
}
