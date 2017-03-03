using ShoeStoreMvvm.Models;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 进货服务
    /// </summary>
    class StockService
        :AbstractEntityBaseClass<Stock>
        ,IStockService
    {
        private readonly IShoeService shoeService;
        public StockService(StockManager stockManager,IShoeService shoeService)
        {
            this.entityManager = stockManager;
            this.shoeService = shoeService;
        }
        /// <summary>
        /// 存货还有问题 后期根据实际业务逻辑修改
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="StockCompanyName"></param>
        /// <param name="shoeItems"></param>
        /// <returns></returns>
        public Stock Stock(DateTime dateTime, string StockCompanyName, IList<ShoeItem> shoeItems)
        {
            Stock tempStock = new Stock(dateTime, shoeItems.Count,StockCompanyName);
           Stock stock = this.Update(tempStock);
           //DealShoes(shoeItems, stock);
           return stock;
        }
        private void DealShoes(IList<Shoe> shoes,Stock stock)
        {
            foreach (var shoe in shoes)
            {
                shoe.StockId = stock.StockId;
                this.shoeService.Save(shoe);
            }
        }
    }
}
