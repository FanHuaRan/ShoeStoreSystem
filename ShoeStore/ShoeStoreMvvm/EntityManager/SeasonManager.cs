using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Season管理类
    /// 2017/02/05 fhr
    /// </summary>
    class SeasonManager : EntityBaseManager<Season>, IEntityManager<Season>
    {
        public Season FindBySeasonName(string seasonName)
        {
            Season season = context.Seasons
                .Where(p => p.SeasonName == seasonName)
                .FirstOrDefault();
            return season;
        }
        public SeasonManager()
            : base()
        {

        }
      
    }
}
