using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Context
{
    /// <summary>
    /// 实体上下文类 
    /// 在这儿使用单例 这是一个错误 DbContext不是线程安全的
    /// 目前不会涉及多线程 暂时使用单例
    /// 2017/2/4 fhr
    /// </summary>
    class MyContext : DbContext
    {
        public DbSet<Season> Seasons { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<StockCompany> StockCompanys { get; set; }

        public DbSet<Store> Stores { get; set; }


        public MyContext():base("ConnectDB")
        {

        }
    }
}
