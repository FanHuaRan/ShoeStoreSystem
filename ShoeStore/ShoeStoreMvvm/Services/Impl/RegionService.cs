using Pers.Fhr.ShoeStoreLib.EntityManager;
using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 区域服务类
    /// </summary>
    class RegionService : AbstractEntityBaseClass<Region>, IRegionService
    {
        public RegionService(RegionManager regionManager)
        {
            this.entityManager = regionManager;
        }
        public Region FindRegionByName(string regionName)
        {
            RegionManager regionManager = this.entityManager as RegionManager;
            return regionManager.FindRegionByName(regionName);
        }
    }
}
