using Pers.Fhr.ShoeStoreLib.EntityManager;
using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 鞋子基础和查询服务
    /// </summary>
    class ShoeService
        : AbstractEntityBaseClass<Shoe>
        , IShoeService
    {
        public ShoeService(ShoeManager shoeManager)
        {
            this.entityManager = shoeManager;
        }
        public List<string> FindShoeTypes()
        {
            return this.entityManager.FindBySelect(p => p.ShoeType);
        }
        public List<string> FindSeansons()
        {
            return this.entityManager.FindBySelect(p => p.Season);
        }
    }
}
