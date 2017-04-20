using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    public class Stock : ModelBase<Stock>
    {
        private Int32 stockId;
        private DateTime stockTime;
        private int stockCount;
        private string stockCompany;
        [PrimaryKey]
        public Int32 StockId
        {
            get { return this.stockId; }
            set
            {
                if (this.stockId != value)
                {
                    this.stockId = value;
                    NotifyPropertyChanged(p => p.StockId);
                }
            }
        }
        public DateTime StockTime
        {
            get { return this.stockTime; }
            set
            {
                if (this.stockTime != value)
                {
                    this.stockTime = value;
                    NotifyPropertyChanged(p => p.StockTime);
                }
            }
        }
        public int StockCount
        {
            get { return this.stockCount; }
            set
            {
                if (this.stockCount != value)
                {
                    this.stockCount = value;
                    NotifyPropertyChanged(p => p.StockCount);
                }
            }
        }
        public string StockCompany
        {
            get { return this.stockCompany; }
            set
            {
                if (this.stockCompany != value)
                {
                    this.stockCompany = value;
                    NotifyPropertyChanged(p => p.StockCompany);
                }
            }
        }
        public Stock()
        {

        }
        public Stock(Int32 id, DateTime time, int count, string companay)
        {
            this.StockId = id;
            this.StockTime = time;
            this.StockCount = count;
            this.StockCompany = companay;
        }
        public Stock(DateTime time, int count, string companay)
            : this(-1, time, count, companay)
        {

        }
    }
}
