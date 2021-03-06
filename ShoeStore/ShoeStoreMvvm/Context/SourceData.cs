﻿using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Context
{
    /// <summary>
    /// EF数据库种子
    /// 2016/2/4 fhr
    /// </summary>
     class SourceData :DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            var stock = new Stock(DateTime.Now, 1, "小公司");
            context.Stocks.Add(stock);
            context.SaveChanges();
        }
    }
}
