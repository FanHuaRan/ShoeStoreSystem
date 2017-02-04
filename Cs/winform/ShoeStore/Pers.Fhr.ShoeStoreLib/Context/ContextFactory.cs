using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Context
{
    /// <summary>
    /// 实体上下文工厂
    /// 2016/2/4 fhr
    /// </summary>
    class ContextFactory
    {
        public static MyContext GetContext()
        {
            return MyContext.Instance;
        }
    }
}
