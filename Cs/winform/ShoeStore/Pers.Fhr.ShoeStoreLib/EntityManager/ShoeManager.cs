using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Shoe管理类
    /// 2017/02/06 fhr
    /// </summary>
    class ShoeManager : EntityBaseManager<Shoe>, IEntityManager<Shoe>
    {
        public DbSet<Shoe> Shoes
        {
            get { return context.Shoes; }
        }
        private ShoeManager()
            : base()
        {

        }
        private static ShoeManager instance = null;
        public static ShoeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoeManager();
                }
                return instance;
            }
        }
    }
}
