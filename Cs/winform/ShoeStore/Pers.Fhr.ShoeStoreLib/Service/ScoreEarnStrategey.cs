﻿using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 客户积分累积策略接口
    /// 2017/2/5 fhr
    /// </summary>
    interface ScoreEarnStrategey
    {
        float EarnScore(Customer customer, Sale sale);

    }
}
