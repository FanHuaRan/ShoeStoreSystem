using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    class ShoeManager : EntityBaseManager<Shoe>, IEntityManager<Shoe>
    {
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
