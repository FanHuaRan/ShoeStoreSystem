using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 进货商实体
    /// 2017/2/5 fhr
    /// </summary>
    public class StockCompany:ModelBase<StockCompany>
    {
        private int stockCompanyId;
        private string stockCompanyName;
        private  List<Stock> stocks;
        [PrimaryKeyAttribute]
        public Int32 StockCompanyId
        {
            get { return this.stockCompanyId; }
            set { this.stockCompanyId = value; NotifyPropertyChanged(p => p.StockCompanyId); }
        }

        public string StockCompanyName
        {
            get { return this.stockCompanyName; }
            set { this.stockCompanyName = value; NotifyPropertyChanged(p => p.StockCompanyName); }
        }
       public virtual List<Stock> Stocks
        {
            get { return this.stocks; }
            set { this.stocks = value; NotifyPropertyChanged(p => p.Stocks); }
        }
        public StockCompany(Int32 stockCompanyId, string stockCompanyName)
        {
            this.StockCompanyId = stockCompanyId;
            this.StockCompanyName = stockCompanyName;
        }
    }
}
