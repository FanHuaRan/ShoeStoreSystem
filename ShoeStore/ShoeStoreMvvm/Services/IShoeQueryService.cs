using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 鞋子查询接口
    /// </summary>
   public interface IShoeItemQueryService
    {
        /// <summary>
        /// 查看所有鞋子
        /// </summary>
        /// <returns></returns>
        List<ShoeItem> FindAllShoeItems();
        /// <summary>
        /// 查看没有售出的鞋子
        /// </summary>
        /// <returns></returns>
        List<ShoeItem> FindNoSellShoeItems();
        /// <summary>
        /// 查看已售出的鞋子
        /// </summary>
        /// <returns></returns>
        List<ShoeItem> FindSellShoeItems();
        /// <summary>
        /// 根据年来查看已售出的鞋子
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        List<ShoeItem> FindSellShoeItemsByYear(int year);
        /// <summary>
        /// 根据月来查看已售出的鞋子
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        List<ShoeItem> FindSellShoeItemsByMonth(int year, int month);
        /// <summary>
        /// 查看某人买的鞋子
        /// </summary>
        /// <returns></returns>
        List<ShoeItem> FindSellShoeItems(string phone);
    }
}
