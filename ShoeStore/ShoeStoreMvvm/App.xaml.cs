using Pers.Fhr.ShoeStoreLib.Context;
using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ShoeStoreMvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //通用错误处理
            // this.DispatcherUnhandledException += (sender, e1) => e1.Handled = true;
            //Code First 数据库初始化
            //MyContext context = new MyContext();
            //var stock = new Stock(DateTime.Now, 1, "小公司");
            //context.Stocks.Add(stock);
            //context.SaveChanges();
            using (MyContext context = new MyContext())
            {
                context.Database.Initialize(true);
            }
            System.Data.Entity.Database.SetInitializer<MyContext>(new SourceData());
        }
    }
}
