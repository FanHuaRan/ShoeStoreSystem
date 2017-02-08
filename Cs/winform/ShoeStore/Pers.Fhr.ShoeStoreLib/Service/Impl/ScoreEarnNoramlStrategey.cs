﻿using Pers.Fhr.ShoeStoreLib.Extension;
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
        public ScoreEarnNoramlStrategey()
        {

        }
        public float EarnScore(Entity.Customer customer, Entity.Sale sale)
        {
            return sale.TotalPrice / 10;
        }
    }
}
