using Pers.Fhr.ShoeStoreLib.EntityManager;
using Pers.Fhr.ShoeStoreLib.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Fac
{
    /// <summary>
    /// 单例工厂
    /// </summary>
    class SingleServiceFactory:IServiceFactory
    {
        private ICustomerService customerService = null;
        private IRegionService regionService = null;
        private IScoreCheapStrategey scoreCheapStrategey = null;
        private IScoreEarnStrategey scoreEarnStrategey = null;
        private ISeasonService seasonService = null;
        private ISellShoeService sellShoeService = null;
        private IShoeQueryService shoeQueryService = null;
        private IShoeService shoeService = null;
        private IStatisticsService statisticsService = null;
        private IStockCompanyService stockCompanyService = null;
        private IStockService stockService = null;
        private IStoreService storeService = null;
        public ICustomerService CreateCustomerService()
        {
            if (customerService==null)
            {
                customerService=new CustomerService(new CustomerManager());
            }
            return customerService;
        }
        public IRegionService CreateRegionService()
        {
            if (regionService == null)
            {
                return new RegionService(new RegionManager());
            }
            return regionService;
        }

        public IScoreCheapStrategey CreateScoreCheapNonStrategey()
        {
            if (scoreCheapStrategey == null)
            {
                scoreCheapStrategey= new ScoreCheapNonStrategey();
            }
            return scoreCheapStrategey;
        }

        public IScoreEarnStrategey CreateScoreEarnNoramlStrategey()
        {
            if (scoreEarnStrategey == null)
            {
                scoreEarnStrategey = new ScoreEarnNoramlStrategey();
            }
            return scoreEarnStrategey;
        }

        public ISeasonService CreateSeasonService()
        {
            if(seasonService==null)
            {
                seasonService=new SeasonService(new SeasonManager());
            }
            return seasonService; 
        }

        public ISellShoeService CreateSellShoeService()
        {
            if(sellShoeService==null)
            {
                sellShoeService=new SellShoeService(new SaleManager(), CreateShoeService(), CreateCustomerService());
            }
            return sellShoeService;
        }

        public IShoeQueryService CreateShoeQueryService()
        {
            if(shoeQueryService==null)
            {
               shoeQueryService = new ShoeService(new ShoeManager());
            }
            return shoeQueryService;
        }

        public IShoeService CreateShoeService()
        {
            if (shoeService == null)
            {
                shoeService = new ShoeService(new ShoeManager());
            }
            return shoeService;
        }

        public IStatisticsService CreateStatisticsService()
        {
            if (statisticsService == null)
            {
                statisticsService = new StatisticsClass(new ShoeManager());
            }
            return statisticsService;
        }

        public IStockCompanyService CreateStockCompanyService()
        {
            if (stockCompanyService == null)
            {
                stockCompanyService = new StockCompanyService(new StockCompanyManager());
            }
            return stockCompanyService;
        }

        public IStockService CreateStockService()
        {
            if (stockService == null)
            {
                stockService = new StockService(new StockManager(), CreateShoeService(), CreateStockCompanyService());
            }
            return stockService;
        }

        public IStoreService CreateStoreService()
        {
            if (storeService == null)
            {
                storeService = new StoreService(new StoreManager());
            }
            return storeService;
        }
    }
}
