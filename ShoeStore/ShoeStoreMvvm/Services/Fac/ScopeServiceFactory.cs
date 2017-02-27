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
            return new CustomerService(new CustomerManager());
        }

        public IRegionService CreateRegionService()
        {
            return new RegionService(new RegionManager());
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
            return new SeasonService(new SeasonManager());
        }

        public  ISellShoeService CreateSellShoeService()
        {
            return new SellShoeService(new SaleManager(), CreateShoeService(), CreateCustomerService());
        }

        public IShoeQueryService CreateShoeQueryService()
        {
            return new ShoeService(new ShoeManager());
        }

        public IShoeService CreateShoeService()
        {
            return new ShoeService(new ShoeManager());
        }

        public IStatisticsService CreateStatisticsService()
        {
            return new StatisticsClass(new ShoeManager());
        }

        public IStockCompanyService CreateStockCompanyService()
        {
            return new StockCompanyService(new StockCompanyManager());
        }

        public IStockService CreateStockService()
        {
            return new StockService(new StockManager(), CreateShoeService(), CreateStockCompanyService());
        }

        public IStoreService CreateStoreService()
        {
            return new StoreService(new StoreManager());
        }
    }
}
