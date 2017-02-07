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
    class ScoreCheapNonStrategey : IScoreCheapStrategey, ISingleDP<ScoreCheapNonStrategey>
    {
        public float CheapMoney(Entity.Customer customer, Entity.Sale sale)
        {
            return 0f;
        }
        private ScoreCheapNonStrategey()
        {

        }
        private ScoreCheapNonStrategey instance = null;
        public ScoreCheapNonStrategey Instance
        {
            get
            {
                CreateSingleInstance();
                return instance;
            }
        }

        public ScoreCheapNonStrategey CreateSingleInstance()
        {
            if (instance == null)
            {
                instance = new ScoreCheapNonStrategey();
            }
            return instance;
        }
    }
}
