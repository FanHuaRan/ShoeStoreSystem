using Pers.Fhr.ShoeStoreLib.EntityManager;
using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    class ShoeItemServiceClass : AbstractEntityBaseClass<ShoeItem>,IShoeItemService,IShoeItemQueryService
    {
        public ShoeItemServiceClass(ShoeItemManager shoeItemManager)
        {
            this.entityManager = shoeItemManager;
        }
        private ShoeItemManager GetShoeItemManager()
        {
            return this.entityManager as ShoeItemManager;
        }
        public IList<ShoeItem> FindAllShoeItems()
        {
           return GetShoeItemManager().FindAll();
        }

        public IList<ShoeItem> FindNoSellShoeItems()
        {
            return GetShoeItemManager().FindNoSellShoeItems();
        }

        public IList<ShoeItem> FindSellShoeItems()
        {
            return GetShoeItemManager().FindSellShoeItems();
        }

        public IList<ShoeItem> FindSellShoeItemsByYear(int year)
        {
            return GetShoeItemManager().FindSellShoeItemsByYear(year);
        }

        public IList<ShoeItem> FindSellShoeItemsByMonth(int year, int month)
        {
            return GetShoeItemManager().FindSellShoeItemsByMonth(year, month);
        }

        public IList<ShoeItem> FindSellShoeItems(string phone)
        {
            return GetShoeItemManager().FindSellShoeItems(phone);
        }
    }
}
