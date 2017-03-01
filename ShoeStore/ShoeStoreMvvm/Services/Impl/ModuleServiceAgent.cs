using ShoeStoreMvvm.Models;
using ShoeStoreMvvm.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services.Impl
{
    public class ModuleServiceAgent:IModuleServiceAgent
    {
        public ObservableCollection<ModuleClass> GetModuleList()
        {
            var moduleList = new ObservableCollection<ModuleClass>()
            {
                new ModuleClass("进货管理","/Resources/Images/15.png",typeof(StockView)),
                 new ModuleClass("存货管理","/Resources/Images/15.png",typeof(StoreView)),
                  new ModuleClass("出售管理","/Resources/Images/15.png",typeof(SellOrderView)),
                   new ModuleClass("查询统计","/Resources/Images/15.png",typeof(StatisticsView))
            };
            return moduleList;
        }
    }
}
