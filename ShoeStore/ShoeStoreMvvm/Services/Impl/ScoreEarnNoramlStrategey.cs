using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 一般积分争取
    /// 2017/2/5 fhr
    /// </summary>
    class ScoreEarnNoramlStrategey
        : IScoreEarnStrategey
    {
        public float EarnScore(Customer customer, Order order)
        {
            return order.TotalPrice / 10;
        }
    }
}
