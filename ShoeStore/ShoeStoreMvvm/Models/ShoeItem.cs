using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    public class ShoeItem:ModelBase<ShoeItem>
    {
        private long shoeItemId;
        private long shoeId;
        private long orderId;
        private byte isSell;
        private string color;
        private float size;
        private float? sellPrice;
        private virtual Shoe shoe;
        private virtual Order order;
        [PrimaryKeyAttribute]
        public Int64 ShoeItemId
        {
            get { return this.shoeItemId; }
            set { this.shoeItemId = value; NotifyPropertyChanged(p => p.ShoeItemId); }
        }
        public Int64 ShoeId
        {
            get { return this.shoeId; }
            set { this.shoeId = value; NotifyPropertyChanged(p => p.ShoeId); }
        }
        public Int64 OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; NotifyPropertyChanged(p => p.OrderId); }
        }
        public byte IsSell
        {
            get { return this.isSell; }
            set { this.isSell = value; NotifyPropertyChanged(p => p.IsSell); }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; NotifyPropertyChanged(p => p.Color); }
        }
        public float Size
        {
            get { return this.size; }
            set { this.size = value; NotifyPropertyChanged(p => p.Size); }
        }
        public float? SellPrice
        {
            get { return this.sellPrice; }
            set { this.sellPrice = value; NotifyPropertyChanged(p => p.SellPrice); }
        }
        public virtual Shoe Shoe
        {
            get { return this.shoe; }
            set { this.shoe = value; NotifyPropertyChanged(p => p.Shoe); }
        }
        public virtual Order Order
        {
            get { return this.order; }
            set { this.order = value; NotifyPropertyChanged(p => p.Order); }
        }
    }
}
