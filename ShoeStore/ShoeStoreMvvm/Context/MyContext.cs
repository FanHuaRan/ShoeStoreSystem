using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Context
{
    /// <summary>
    /// 实体上下文类 
    /// 非线程安全
    /// 目前不会涉及多线程 暂时使用单例
    /// 2017/2/4 fhr
    /// </summary>
    class MyContext : DbContext
    {
        public DbSet<Season> Seasons { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<ShoeItem> ShoeItems { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<StockCompany> StockCompanys { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Order> Orders { get; set; }

        public MyContext():base("ConnectDB")
        {

        }
        //去掉表名复数
        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
