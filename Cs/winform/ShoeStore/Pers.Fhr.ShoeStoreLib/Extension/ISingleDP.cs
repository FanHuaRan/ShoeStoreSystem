using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Extension
{
    /// <summary>
    /// 单例接口
    /// 同时也应用到了模板方法
    /// </summary>
    public interface ISingleDP<T> where T:class
    {
         T Instance { get; }
         T CreateSingleInstance();
    }
}
