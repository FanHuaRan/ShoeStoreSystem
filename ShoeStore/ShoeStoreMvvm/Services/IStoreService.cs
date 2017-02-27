using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 存鞋接口
    /// </summary>
    public interface IStoreService
    {
        Store StoreShoes(Shoe shoe,Region region,string more);
    }
}
