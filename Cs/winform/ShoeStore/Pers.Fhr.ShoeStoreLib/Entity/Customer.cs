using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 客户信息
    /// 2017/2/5 fhr
    /// </summary>
    class Customer
    {

        [PrimaryKeyAttribute]
        public Int64 CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public float Score { get; set; }
    }
}
