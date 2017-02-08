using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Fac
{
    /// <summary>
    /// 服务工厂接口
    /// </summary>
    public interface IServiceFactory
    {
        ICustomerService CreateCustomerService();
        IRegionService CreateRegionService();
        IScoreCheapStrategey CreateScoreCheapNonStrategey();
        IScoreEarnStrategey CreateScoreEarnNoramlStrategey();
        ISeasonService CreateSeasonService();
        ISellShoeService CreateSellShoeService();
        IShoeQueryService CreateShoeQueryService();
        IShoeService CreateShoeService();
        IStatisticsService CreateStatisticsService();
        IStockCompanyService CreateStockCompanyService();
        IStockService CreateStockService();
        IStoreService CreateStoreService();
    }
}
