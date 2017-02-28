using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    public class Order : ModelBase<Order>
    {
        private long orderId;
        private long? customerId;
        private DateTime saleTime;
        private float totalPrice;
        private int count;
        private Customer customer;
        [PrimaryKeyAttribute]
        public Int64 OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; NotifyPropertyChanged(p => p.OrderId); }
        }
        public Int64? CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; NotifyPropertyChanged(p => p.CustomerId); }
        }
        public DateTime SaleTime
        {
            get { return this.saleTime; }
            set { this.saleTime = value; NotifyPropertyChanged(p => p.SaleTime); }
        }
        public float TotalPrice
        {
            get { return this.totalPrice; }
            set { this.totalPrice = value; NotifyPropertyChanged(p => p.TotalPrice); }
        }
        public Int32 Count
        {
            get { return this.count; }
            set { this.count = value; NotifyPropertyChanged(p => p.Count); }
        }
        public virtual Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; NotifyPropertyChanged(p => p.Customer); }
        }

        public Order(long? customerId, DateTime saleTime, float totalPrice)
        {
            // TODO: Complete member initialization
            this.CustomerId = customerId;
            this.SaleTime = saleTime;
            this.TotalPrice = totalPrice;
        }
    }
}
