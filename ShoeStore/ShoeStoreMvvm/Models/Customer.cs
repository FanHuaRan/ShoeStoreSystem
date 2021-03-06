﻿using Pers.Fhr.ShoeStoreLib.Component;
using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 客户信息
    /// 2017/2/5 fhr
    /// </summary>
    public class Customer : ModelBase<Customer>
    {

        private Int32 customerId;
        private string phone;
        private float score;

        [PrimaryKey]
        public Int32 CustomerId
        {
            get { return this.customerId; }
            set
            {
                if (this.customerId != value)
                {
                    this.customerId = value; 
                    NotifyPropertyChanged(p => p.CustomerId);
                }
            }
        }


        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (this.phone != value)
                {
                    this.phone = value;
                    NotifyPropertyChanged(p => p.Phone);
                }
            }
        }
        public float Score
        {
            get { return this.score; }
            set
            {
                if (this.score != value)
                {
                    this.score = value;
                    NotifyPropertyChanged(p => p.Score);
                }
            }
        }
        public Customer(Int32 customerId, string phone, float score)
        {
            this.CustomerId = customerId;
            this.Phone = phone;
            this.Score = score;
        }
        public Customer(string phone, float score)
            : this(-1, phone, score)
        {

        }
    }
}
