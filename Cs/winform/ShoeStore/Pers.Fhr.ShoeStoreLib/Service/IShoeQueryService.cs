using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 鞋子查询接口
    /// </summary>
   public interface IShoeQueryService
    {
        /// <summary>
        /// 查看所有鞋子
        /// </summary>
        /// <returns></returns>
        IList<Shoe> FindAllShoes();
        /// <summary>
        /// 查看没有售出的鞋子
        /// </summary>
        /// <returns></returns>
        IList<Shoe> FindNoSellShoes();
        /// <summary>
        /// 查看已售出的鞋子
        /// </summary>
        /// <returns></returns>
        IList<Shoe> FindSellShoes();
        /// <summary>
        /// 根据年来查看已售出的鞋子
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IList<Shoe> FindSellShoesByYear(int year);
        /// <summary>
        /// 根据月来查看已售出的鞋子
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IList<Shoe> FindSellShoesByMonth(int year, int month);
        /// <summary>
        /// 查看某人买的鞋子
        /// </summary>
        /// <returns></returns>
        IList<Shoe> FindSellShoes(string phone);
    }
}
