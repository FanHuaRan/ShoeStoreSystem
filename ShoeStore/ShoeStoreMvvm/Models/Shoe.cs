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
        private Int32 shoeId;
        private Int32 stockId;
        private Int32 thingId;
        private float originMoney;
        private float price;
        private byte gender;
        private string season;
        private Stock stock;
        private string shoeType;
        private List<ShoeItem> shoeItems;

        [PrimaryKey]
        public Int32 ShoeId
        {
            get { return this.shoeId; }
            set
            {
                if (this.shoeId != value)
                {
                    this.shoeId = value;
                    NotifyPropertyChanged(p => p.ShoeId);
                }
            }
        }
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
        public Int32 ThingId
        {
            get { return this.thingId; }
            set
            {
                if (this.thingId != value)
                {
                    this.thingId = value;
                    NotifyPropertyChanged(p => p.ThingId);
                }
            }
        }
        //成本价
        public float OriginMoney
        {
            get { return this.originMoney; }
            set
            {
                if (this.originMoney != value)
                {
                    this.originMoney = value;
                    NotifyPropertyChanged(p => p.OriginMoney);
                }
            }
        }
        //零售价
        public float Price
        {
            get { return this.price; }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    NotifyPropertyChanged(p => p.Price);
                }
            }
        }
        public byte Gender
        {
            get { return this.gender; }
            set
            {
                if (this.gender != value)
                {
                    this.gender = value;
                    NotifyPropertyChanged(p => p.Gender);
                }
            }
        }
        public string Season
        {
            get { return this.season; }
            set
            {
                if (this.season != value)
                {
                    this.season = value;
                    NotifyPropertyChanged(p => p.Season);
                }
            }
        }
        public string ShoeType
        {
            get { return this.shoeType; }
            set
            {
                if (this.shoeType != value)
                {
                    this.shoeType = value;
                    NotifyPropertyChanged(p => p.ShoeType);
                }
            }
        }
        public virtual Stock Stock
        {
            get { return this.stock; }
            set
            {
                if (this.stock != value)
                {
                    this.stock = value;
                    NotifyPropertyChanged(p => p.Stock);
                }
            }
        }
        public virtual List<ShoeItem> ShoeItems
        {
            get { return this.shoeItems; }
            set
            {
                if (this.shoeItems != value)
                {
                    this.shoeItems = value;
                    NotifyPropertyChanged(p => p.ShoeItems);
                }
            }
        }
    }
}
