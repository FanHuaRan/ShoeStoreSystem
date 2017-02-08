using Pers.Fhr.ShoeStoreLib.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pers.Fhr.ShoeStoreLib.EntityManager;
namespace Pers.Fhr.ShoeStoreLib.Service.Fac
{
    /// <summary>
    /// 原型工厂
    /// </summary>
    class ScopeServiceFactory:IServiceFactory
    {
        public ICustomerService CreateCustomerService()
        {
            return new CustomerService(CustomerManager.Instance);
        }

        public IRegionService CreateRegionService()
        {
            return new RegionService(RegionManager.Instance);
        }

        public IScoreCheapStrategey CreateScoreCheapNonStrategey()
        {
            return new ScoreCheapNonStrategey();
        }

        public IScoreEarnStrategey CreateScoreEarnNoramlStrategey()
        {
            return new ScoreEarnNoramlStrategey();
        }

        public ISeasonService CreateSeasonService()
        {
            return new SeasonService(SeasonManager.Instance);
        }

        public  ISellShoeService CreateSellShoeService()
        {
            return new SellShoeService(SaleManager.Instance, CreateShoeService(), CreateCustomerService());
        }

        public IShoeQueryService CreateShoeQueryService()
        {
            return new ShoeService(ShoeManager.Instance);
        }

        public IShoeService CreateShoeService()
        {
            return new ShoeService(ShoeManager.Instance);
        }

        public IStatisticsService CreateStatisticsService()
        {
            return new StatisticsClass(ShoeManager.Instance);
        }

        public IStockCompanyService CreateStockCompanyService()
        {
            return new StockCompanyService(StockCompanyManager.Instance);
        }

        public IStockService CreateStockService()
        {
            return new StockService(StockManager.Instance, CreateShoeService(), CreateStockCompanyService());
        }

        public IStoreService CreateStoreService()
        {
            return new StoreService(StoreManager.Instance);
        }
    }
}
