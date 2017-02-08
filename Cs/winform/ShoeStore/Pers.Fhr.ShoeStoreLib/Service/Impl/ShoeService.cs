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
    /// 鞋子基础和查询服务
    /// </summary>
    class ShoeService
        :AbstractEntityBaseClass<Shoe,ShoeService>
        ,IShoeService,IShoeQueryService
    {
        public IList<Shoe> FindAllShoes()
        {
            return FindAll();
        }
        private ShoeManager GetShoeManager()
        {
            return this.entityManager as ShoeManager;
        }
        public IList<Shoe> FindNoSellShoes()
        {
           return GetShoeManager().FindNoSellShoes();
        }

        public IList<Shoe> FindSellShoes()
        {
            return GetShoeManager().FindSellShoes();
        }

        public IList<Shoe> FindSellShoesByYear(int year)
        {
            return GetShoeManager().FindSellShoesByYear(year);
        }

        public IList<Shoe> FindSellShoesByMonth(int year, int month)
        {
            return GetShoeManager().FindSellShoesByMonth(year, month);
        }

        public IList<Shoe> FindSellShoes(string phone)
        {
            throw new NotImplementedException();
        }
        public ShoeService(ShoeManager shoeManager)
        {
            this.entityManager = shoeManager;
        }
    }
}
