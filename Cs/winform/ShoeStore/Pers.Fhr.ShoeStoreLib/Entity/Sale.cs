using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Entity
{
    /// <summary>
    /// 销售信息
    /// 2017/2/5 fhr
    /// </summary>
    class Sale
    {
        [PrimaryKeyAttribute]
        public Int64 SaleId { get; set; }

        public Int64 CustomerId { get; set; }

        public string? Phone { get; set; }

        public DateTime SaleTime { get; set; }

        public float TotalPrice { get; set; }
    }
}
