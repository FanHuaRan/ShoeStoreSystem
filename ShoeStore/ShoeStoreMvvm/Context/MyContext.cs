﻿using ShoeStoreMvvm.Models;
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
    /// 2017/2/4 fhr
    /// </summary>
    class MyContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<ShoeItem> ShoeItems { get; set; }

        public DbSet<Stock> Stocks { get; set; }


        public DbSet<Store> Stores { get; set; }

        public DbSet<Order> Orders { get; set; }

        public MyContext()
            : base("shoedb")
        {

        }
        //去掉表名复数
        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
