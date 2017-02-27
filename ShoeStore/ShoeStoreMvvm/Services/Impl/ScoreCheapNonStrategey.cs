using Pers.Fhr.ShoeStoreLib.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 无优惠策略
    /// 2017/2/5 fhr
    /// </summary>
    class ScoreCheapNonStrategey : IScoreCheapStrategey
    {
        public float CheapMoney(Entity.Customer customer, Entity.Sale sale)
        {
            return 0f;
        }
        public ScoreCheapNonStrategey()
        {

        }
    }
}
