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
    /// 实体上下文类 单例
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


        private MyContext():base("ConnectDB")
        {

        }
        private static MyContext _context=null;
        public static MyContext Instance
        {
            get
            {
                if (_context == null)
                {
                    _context = new MyContext();
                }
                return _context;
            }
        }
    }
}
