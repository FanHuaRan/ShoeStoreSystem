using Pers.Fhr.ShoeStoreLib.Entity;
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
        :AbstractEntityBaseClass<Stock,StockService>
        ,IStockService
    {
        private readonly IShoeService shoeService;
        private readonly IStockCompanyService stockCompanyService;
        private StockService(IShoeService shoeService, IStockService stockService, IStockCompanyService stockCompanyService)
        {
            this.shoeService = shoeService;
            this.stockCompanyService = stockCompanyService;
        }
        public Stock Stock(DateTime dateTime, string StockCompanyName, IList<Shoe> shoes)
        {
           Stock stock=new Stock();
           stock.StockCompanyId = DealStockCompany(StockCompanyName);
           stock.StockCount = shoes.Count;
           stock.StockTime = dateTime;
        }
        private int DealStockCompany(string StockCompanyName)
        {
            StockCompany company=this.stockCompanyService.FindStockCompanyByName(StockCompanyName);
            if (company == null)
            {
                StockCompany tempCompany = new StockCompany(-1, StockCompanyName);
                company=this.stockCompanyService.Save(company);
            }
            return company.StockCompanyId;
        }
        private void DealShoes(IList<Shoe> shoes,Stock stock)
        {
        }
        public override StockService CreateSingleInstance()
        {
            if (instance == null)
            {
                instance = new StockService();
            }
            return instance;
        }
    }
}
