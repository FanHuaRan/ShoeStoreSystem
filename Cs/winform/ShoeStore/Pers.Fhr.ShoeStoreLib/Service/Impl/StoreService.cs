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
    /// 存储实现
    /// </summary>
    class StoreService
        : AbstractEntityBaseClass<Store,StoreService>
        ,IStoreService
    {
        public StoreService(StoreManager storeManager)
        {
            this.entityManager = storeManager;
        }
        public Store StoreShoes(Shoe shoe, Region region, string more)
        {
            Store store = new Store(shoe.ShoeId,region.RegionId,more);
            return this.entityManager.Insert(store);
        }
    }
}
