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
        public List<ShoeItem> FindAllShoeItems()
        {
            // return GetShoeItemManager().FindAll();
            return new List<ShoeItem>(){
                new ShoeItem(){
                    ShoeItemId=1,
                    Size=40,
                    Color="黑色",
                    Shoe=new Shoe(){
                        ShoeType="休闲鞋",
                        Season="春季",
                        Gender=1,
                        Price=9.98f
                    }
                }
            };
        }

        public List<ShoeItem> FindNoSellShoeItems()
        {
            return GetShoeItemManager().FindNoSellShoeItems();
        }

        public List<ShoeItem> FindSellShoeItems()
        {
            return GetShoeItemManager().FindSellShoeItems();
        }

        public List<ShoeItem> FindSellShoeItemsByYear(int year)
        {
            return GetShoeItemManager().FindSellShoeItemsByYear(year);
        }

        public List<ShoeItem> FindSellShoeItemsByMonth(int year, int month)
        {
            return GetShoeItemManager().FindSellShoeItemsByMonth(year, month);
        }

        public List<ShoeItem> FindSellShoeItems(string phone)
        {
            return GetShoeItemManager().FindSellShoeItems(phone);
        }
    }
}
