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
    /// 统计实现
    /// </summary>
    class StatisticsClass : IStatisticsService
    {
        private readonly ShoeManager shoeManager;
        private readonly ShoeItemManager shoeItemManager;

        public float StatisticsTotalCountMoney()
        {
            return shoeItemManager.ShoeItems
              .Select(p=>p)
              .Sum(p => p.Shoe.OriginMoney);
        }
        public float StatisticsTotalSellMoney()
        {
            return shoeItemManager.ShoeItems
             .Where(p => p.IsSell == 1)
             .Sum(p => p.Shoe.OriginMoney);
        }

        public float StatisticsTotalCountMoneyByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return shoeItemManager.ShoeItems
             .Where(p => p.Shoe.Stock.StockTime >= minTime
                      && p.Shoe.Stock.StockTime < maxTime)
                      .Sum(p => p.Shoe.OriginMoney);
        }

        public float StatisticsTotalSellMoneyByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return shoeItemManager.ShoeItems
             .Where(p => p.IsSell == 1
                      && p.Order.SaleTime >= minTime
                      && p.Order.SaleTime < maxTime)
                      .Sum(p => p.SellPrice) ?? 0;
        }

        public float StatisticsTotalCountMoneyByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year+1, 01, 01);
            return shoeItemManager.ShoeItems
             .Where(p => p.IsSell == 1
                      && p.Order.SaleTime >= minTime
                      && p.Order.SaleTime < maxTime)
                      .Sum(p => p.Shoe.Price);
        }

        public float StatisticsTotalSellMoneyByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year + 1, 01, 01);
            return shoeItemManager.ShoeItems
             .Where(p => p.IsSell == 1
                      && p.Order.SaleTime >= minTime
                      && p.Order.SaleTime < maxTime)
                      .Sum(p => p.SellPrice)??0;
        }

        public float CountSellMoney(List<ShoeItem> shoeItems)
        {
            return shoeItems.Sum(p => p.SellPrice).Value;
        }
        public StatisticsClass(ShoeManager shoeManager)
        {
            this.shoeManager = shoeManager;
        }
    }
}
