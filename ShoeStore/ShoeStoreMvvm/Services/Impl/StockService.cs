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
        private readonly IStockCompanyService stockCompanyService;
        public StockService(StockManager stockManager,IShoeService shoeService, IStockCompanyService stockCompanyService)
        {
            this.entityManager = stockManager;
            this.shoeService = shoeService;
            this.stockCompanyService = stockCompanyService;
        }
        public Stock Stock(DateTime dateTime, string StockCompanyName, IList<Shoe> shoes)
        {
           Stock tempStock=new Stock(DealStockCompany(StockCompanyName),dateTime, shoes.Count);
           Stock stock = this.Update(tempStock);
           DealShoes(shoes, stock);
           return stock;
        }
        private int DealStockCompany(string StockCompanyName)
        {
            StockCompany company = stockCompanyService.PutIfAbsent(StockCompanyName);
            return company.StockCompanyId;
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
