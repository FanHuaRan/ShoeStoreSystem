using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 鞋子基本服务
    /// </summary>
    public interface IShoeService:IBaseEntityService<Shoe>
    {
        List<string> FindShoeTypes();
        List<string> FindSeasons();
        /*
        /// <summary>
        /// 录入鞋信息
        /// </summary>
        /// <param name="shoe"></param>
        /// <returns></returns>
        bool InputShoe(Shoe shoe);
        /// <summary>
        /// 更新鞋信息
        /// </summary>
        /// <param name="shoe"></param>
        /// <returns></returns>
        bool UpdateShoe(Shoe shoe);
        /// <summary>
        /// 删除鞋
        /// </summary>
        /// <param name="shoeId"></param>
        /// <returns></returns>
        bool DeleteShoe(Int64 shoeId);
         * */
    }
}
