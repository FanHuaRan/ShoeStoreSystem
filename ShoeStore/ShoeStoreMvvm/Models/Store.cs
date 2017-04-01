using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private Int32 storeId;
        private Int32 shoeItemId;
        private Int32 regionId;
        private string moreInfo;
        private ShoeItem shoeItem;
        public Int32 StoreId
        {
            get { return this.storeId; }
            set { this.storeId = value; NotifyPropertyChanged(p => p.StoreId); }
        }

        public Int32 ShoeItemId
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
        [Required]
        public virtual ShoeItem ShoeItem
        {
            get { return shoeItem; }
            set { shoeItem = value; }
        }
        public Store(Int32 storeId, Int32 shoeItemId, Int32 regionId, string more)
        {
            this.StoreId = storeId;
            this.ShoeItemId = shoeItemId;
            this.RegionId = regionId;
            this.MoreInfo = more;
        }
        public Store(Int32 shoeId, Int32 regionId, string more)
            : this(-1,shoeId,regionId,more)
        {

        }
    }
}
