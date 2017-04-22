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
        public IEnumerable<ShoeItem> FindAllShoeItems()
        {
             return GetShoeItemManager().FindAll();
            //return new List<ShoeItem>(){
            //    new ShoeItem(){
            //        ShoeItemId=1,
            //        Size=40,
            //        Color="黑色",
            //        Shoe=new Shoe(){
            //            ShoeType="休闲鞋",
            //            Season="春季",
            //            Gender=1,
            //            Price=9.98f
            //        }
            //    }
            //};
        }

        public IEnumerable<ShoeItem> FindNoSellShoeItems()
        {
            return GetShoeItemManager().FindNoSellShoeItems();
        }

        public IEnumerable<ShoeItem> FindSellShoeItems()
        {
            return GetShoeItemManager().FindSellShoeItems();
        }

        public IEnumerable<ShoeItem> FindSellShoeItemsByYear(int year)
        {
            return GetShoeItemManager().FindSellShoeItemsByYear(year);
        }

        public IEnumerable<ShoeItem> FindSellShoeItemsByMonth(int year, int month)
        {
            return GetShoeItemManager().FindSellShoeItemsByMonth(year, month);
        }

        public IEnumerable<ShoeItem> FindSellShoeItems(string phone)
        {
            return GetShoeItemManager().FindSellShoeItems(phone);
        }

        public IEnumerable<float> FindShoeItemSizes(IEnumerable<ShoeItem> shoeItems)
        {
            return shoeItems.Select(p => p.Size).Distinct();
        }
       
        public IEnumerable<float> FindShoeItemSizes()
        {
            return this.entityManager.Context.ShoeItems
                                             .Select(p => p.Size)
                                             .Distinct();
        }
       
        public IEnumerable<string> FindShoeItemColors(IEnumerable<ShoeItem> shoeItems)
        {
            return shoeItems.Select(p => p.Color).Distinct();
        }
     
        public IEnumerable<string> FindShoeItemColors()
        {
            return this.entityManager.Context.ShoeItems
                                             .Select(p => p.Color)
                                             .Distinct();
        }

        public IEnumerable<ShoeItem> FindShoeItems(List<Func<ShoeItem, bool>> conditions)
        {
            return GetShoeItemManager().SimpleCompositeFind(conditions.ToArray());
        }
    }
}
