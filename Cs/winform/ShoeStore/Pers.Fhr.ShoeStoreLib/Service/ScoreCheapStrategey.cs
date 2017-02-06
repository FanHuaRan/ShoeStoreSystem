using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 客户积分优惠策略接口
    /// 2017/2/5 fhr
    /// </summary>
    interface ScoreCheapStrategey
    {
        float CheapMoney(Customer customer, Sale sale);
    }
}
