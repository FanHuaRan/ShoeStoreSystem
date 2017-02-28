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
        public IList<Shoe> FindAllShoes()
        {
            return FindAll();
        }
    }
}
