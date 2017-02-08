using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 销售服务
    /// </summary>
    public interface ISellShoeService
    {
        /// <summary>
        /// 积分优惠策略属性
        /// </summary>
        IScoreCheapStrategey ScoreCheapStrategey { get; set; }

        /// <summary>
        /// 积分累积策略
        /// </summary>
        IScoreEarnStrategey ScoreEarnStrategey { get; set; }

        /// <summary>
        /// 销售鞋子
        /// </summary>
        /// <returns></returns>
        Sale SellShoe(DateTime saleTime, List<Shoe> selledShoes, string phone);
    }
}
