using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 季节实体
    /// 2017/2/4 fhr
    /// </summary>
    class Season
    {
        public Int32 SeasonId { get; set; }

        public string SeasonName { get; set; }

        public Season(Int32 seasonId, string seasonName)
        {
            this.SeasonId = seasonId;
            this.SeasonName = seasonName;
        }
        public Season(string seasonName)
        {
            this.SeasonName = seasonName;
        }
    }
}
