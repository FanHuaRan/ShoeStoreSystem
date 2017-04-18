using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    public class ShoeItem : ModelBase<ShoeItem>
    {
        private Int32 shoeItemId;
        private Int32 shoeId;
        private Int32 orderId;
        private byte isSell;
        private string color;
        private float size;
        private float? sellPrice;
        private Shoe shoe;
        private Order order;
        [PrimaryKey]
        public Int32 ShoeItemId
        {
            get { return this.shoeItemId; }
            set
            {
                if (this.shoeItemId != value)
                {
                    this.shoeItemId = value;
                    NotifyPropertyChanged(p => p.ShoeItemId);
                }
            }
        }
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
        public Int32 OrderId
        {
            get { return this.orderId; }
            set
            {
                if (this.orderId != value)
                {
                    this.orderId = value;
                    NotifyPropertyChanged(p => p.OrderId);
                }
            }
        }
        public byte IsSell
        {
            get { return this.isSell; }
            set
            {
                if (this.isSell != value)
                {
                    this.isSell = value;
                    NotifyPropertyChanged(p => p.IsSell);
                }
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                if (this.color != value)
                {
                    this.color = value;
                    NotifyPropertyChanged(p => p.Color);
                }
            }
        }
        public float Size
        {
            get { return this.size; }
            set
            {
                if (this.size != value)
                {
                    this.size = value;
                    NotifyPropertyChanged(p => p.Size);
                }
            }
        }
        public float? SellPrice
        {
            get { return this.sellPrice; }
            set
            {
                if (this.sellPrice != value)
                {
                    this.sellPrice = value;
                    NotifyPropertyChanged(p => p.SellPrice);
                }
            }
        }
        public virtual Shoe Shoe
        {
            get { return this.shoe; }
            set
            {
                if (this.shoe != value)
                {
                    this.shoe = value;
                    NotifyPropertyChanged(p => p.Shoe);
                }
            }
        }
        [Required]
        public virtual Order Order
        {
            get { return this.order; }
            set
            {
                if (this.order != value)
                {
                    this.order = value;
                    NotifyPropertyChanged(p => p.Order);
                }
            }
        }
    }
}
