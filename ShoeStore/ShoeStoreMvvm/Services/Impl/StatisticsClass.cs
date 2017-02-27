using Pers.Fhr.ShoeStoreLib.Entity;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using Pers.Fhr.ShoeStoreLib.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 统计实现
    /// </summary>
    class StatisticsClass : IStatisticsService
    {
        private readonly ShoeManager shoeManager;

        public float StatisticsTotalCountMoney()
        {
          return  shoeManager.Shoes
              .Select(p=>p)
              .Sum(p => p.OriginMoney);
        }
        public float StatisticsTotalSellMoney()
        {
            return shoeManager.Shoes
             .Where(p => p.IsSell == 1)
             .Sum(p => p.OriginMoney);
        }

        public float StatisticsTotalCountMoneyByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return shoeManager.Shoes
             .Where(p => p.Stock.StockTime >= minTime
                      && p.Stock.StockTime < maxTime)
                      .Sum(p => p.OriginMoney);
        }

        public float StatisticsTotalSellMoneyByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return shoeManager.Shoes
             .Where(p => p.IsSell == 1
                      && p.Sale.SaleTime >= minTime
                      && p.Sale.SaleTime < maxTime)
                      .Sum(p => p.OriginMoney);
        }

        public float StatisticsTotalCountMoneyByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year+1, 01, 01);
            return shoeManager.Shoes
             .Where(p => p.IsSell == 1
                      && p.Sale.SaleTime >= minTime
                      && p.Sale.SaleTime < maxTime)
                      .Sum(p => p.OriginMoney);
        }

        public float StatisticsTotalSellMoneyByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year + 1, 01, 01);
            return shoeManager.Shoes
             .Where(p => p.IsSell == 1
                      && p.Sale.SaleTime >= minTime
                      && p.Sale.SaleTime < maxTime)
                      .Sum(p => p.OriginMoney);
        }

        public float CountSellMoney(List<Entity.Shoe> Shoes)
        {
            return Shoes.Sum(p => p.SellPrice).Value;
        }
        public StatisticsClass(ShoeManager shoeManager)
        {
            this.shoeManager = shoeManager;
        }
    }
}
