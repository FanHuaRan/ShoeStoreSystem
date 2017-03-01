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
    /// 鞋信息
    /// 2017/2/5 fhr
    /// </summary>
    public class Shoe : ModelBase<Shoe>
    {
        private long seasonId;
        private long stockId;
        private int thingId;
        private float originMoney;
        private float price;
        private byte gender;
        private Stock stock;
        private Season season;
        private virtual List<ShoeItem> shoeItems;
        public long shoeId { get; set; }
        [PrimaryKeyAttribute]
        public Int64 ShoeId
        {
            get { return this.shoeId; }
            set { this.shoeId = value; NotifyPropertyChanged(p => p.ShoeId); }
        }
        public Int64 SeasonId
        {
            get { return this.seasonId; }
            set { this.seasonId = value; NotifyPropertyChanged(p => p.SeasonId); }
        }
        public Int64 StockId
        {
            get { return this.stockId; }
            set { this.stockId = value; NotifyPropertyChanged(p => p.StockId); }
        }
        public Int32 ThingId
        {
            get { return this.thingId; }
            set { this.thingId = value; NotifyPropertyChanged(p => p.ThingId); }
        }
        //成本价
        public float OriginMoney
        {
            get { return this.originMoney; }
            set { this.originMoney = value; NotifyPropertyChanged(p => p.OriginMoney); }
        }
        //零售价
        public float Price
        {
            get { return this.price; }
            set { this.price = value; NotifyPropertyChanged(p => p.Price); }
        }
        public byte Gender
        {
            get { return this.gender; }
            set { this.gender = value; NotifyPropertyChanged(p => p.Gender); }
        }
        public virtual Stock Stock
        {
            get { return this.stock; }
            set { this.stock = value; NotifyPropertyChanged(p => p.Stock); }
        }
        public virtual Season Season
        {
            get { return this.season; }
            set { this.season = value; NotifyPropertyChanged(p => p.Season); }
        }
        public virtual List<ShoeItem> ShoeItems
        {
            get { return this.shoeItems; }
            set { this.shoeItems = value; NotifyPropertyChanged(p => p.ShoeItems); }
        }
    }
}
