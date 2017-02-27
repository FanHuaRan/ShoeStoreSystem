using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services
{
    /// <summary>
    /// 统计接口
    /// </summary>
    public interface IStatisticsService
    {
        /// <summary>
        /// 统计总成本
        /// </summary>
        /// <returns></returns>
        float StatisticsTotalCountMoney();
        /// <summary>
        /// 统计总销售
        /// </summary>
        /// <returns></returns>
        float StatisticsTotalSellMoney();
        /// <summary>
        /// 按月统计成本
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        float StatisticsTotalCountMoneyByMonth(int year,int month);
        /// <summary>
        /// 按月统计总销售
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        float StatisticsTotalSellMoneyByMonth(int year,int month);
        /// <summary>
        /// 按年统计总成本
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        float StatisticsTotalCountMoneyByYear(int year);
        /// <summary>
        /// 按年统计总销售
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        float StatisticsTotalSellMoneyByYear(int year);
        /// <summary>
        /// 统计鞋子销售总金额
        /// </summary>
        /// <param name="Shoes"></param>
        /// <returns></returns>
        float CountSellMoney(List<Shoe> Shoes);
    }
}
