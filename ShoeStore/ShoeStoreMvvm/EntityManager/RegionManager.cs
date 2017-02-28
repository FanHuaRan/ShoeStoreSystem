using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Region管理类
    /// 2017/02/05 fhr
    /// </summary>
    class RegionManager : EntityBaseManager<Region>, IEntityManager<Region>
    {
        public Region FindRegionByName(string name)
        {
            return context.Regions.
                Where(p => p.RegionName == name)
                .FirstOrDefault();
        }
        public RegionManager()
            : base()
        {

        }
    }
}

