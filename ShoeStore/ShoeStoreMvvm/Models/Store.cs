using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 存货信息
    /// 2017/2/5 fhr
    /// </summary>
    public class Store : ModelBase<Store>
    {
        private long storeId;
        private long shoeItemId;
        private int regionId;
        private string moreInfo;
        public Int64 StoreId
        {
            get { return this.storeId; }
            set { this.storeId = value; NotifyPropertyChanged(p => p.StoreId); }
        }

        public Int64 ShoeItemId
        {
            get { return this.shoeItemId; }
            set { this.shoeItemId = value; NotifyPropertyChanged(p => p.ShoeItemId); }
        }

        public Int32 RegionId
        {
            get { return this.regionId; }
            set { this.regionId = value; NotifyPropertyChanged(p => p.RegionId); }
        }

        public string MoreInfo
        {
            get { return this.moreInfo; }
            set { this.moreInfo = value; NotifyPropertyChanged(p => p.MoreInfo); }
        }

        public Store(Int64 storeId,Int64 shoeItemId,Int32 regionId,string more)
        {
            this.StoreId = storeId;
            this.ShoeItemId = shoeItemId;
            this.RegionId = regionId;
            this.MoreInfo = more;
        }
        public Store(Int64 shoeId,Int32 regionId,string more)
            : this(-1,shoeId,regionId,more)
        {

        }
    }
}
