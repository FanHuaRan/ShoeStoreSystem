using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 进货
    /// 2017/2/5 fhr
    /// </summary>
    public class Stock:ModelBase<Stock>
    {
        private long stockId;
        private int stockCompanyId;
        private DateTime stockTime;
        private int stockCount;
        private virtual StockCompany stockCompany;
        public Int64 StockId
        {
            get { return this.stockId; }
            set { this.stockId = value; NotifyPropertyChanged(p => p.StockId); }
        }

        public Int32 StockCompanyId
        {
            get { return this.stockCompanyId; }
            set { this.stockCompanyId = value; NotifyPropertyChanged(p => p.StockCompanyId); }
        }
        public DateTime StockTime
        {
            get { return this.stockTime; }
            set { this.stockTime = value; NotifyPropertyChanged(p => p.StockTime); }
        }
        public Int32 StockCount
        {
            get { return this.stockCount; }
            set { this.stockCount = value; NotifyPropertyChanged(p => p.StockCount); }
        }
        public virtual StockCompany StockCompany
        {
            get { return this.stockCompany; }
            set { this.stockCompany = value; NotifyPropertyChanged(p => p.StockCompany); }
        }
        public Stock(Int64 stockId, Int32 stockCompanyId, DateTime stockTime, Int32 stockCount)
        {
            this.StockId = stockId;
            this.StockCompanyId = stockCompanyId;
            this.StockTime = stockTime;
            this.StockCount = stockCount;
        }
        public Stock(Int32 stockCompanyId, DateTime stockTime, Int32 stockCount)
            : this(-1, stockCompanyId, stockTime, stockCount)
        {

        }
    }
}
