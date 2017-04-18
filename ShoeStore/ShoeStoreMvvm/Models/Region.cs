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
    /// 区域实体
    /// 2017/2/4 fhr
    /// </summary>
   public class Region:ModelBase<Region>
    {
       private Int32 regionId;
       private string regionName;
       private string regionAddress;
       private  List<Store> stores;

       [PrimaryKey]
       public Int32 RegionId
       {
           get { return this.regionId; }
           set
           {
               if (this.regionId != value)
               {
                   this.regionId = value;
                   NotifyPropertyChanged(p => p.RegionId);
               }
           }
       }

       public string RegionName
       {
           get { return this.regionName; }
           set
           {
               if (this.regionName != value)
               {
                   this.regionName = value; 
                   NotifyPropertyChanged(p => p.RegionName);
               }
           }
       }

       public string RegionAddress
       {
           get { return this.regionAddress; }
           set
           {
               if (this.regionAddress != value)
               {
                   this.regionAddress = value;
                   NotifyPropertyChanged(p => p.RegionAddress);
               }
           }
       }
       public virtual List<Store> Stores
       {
           get { return this.stores; }
           set
           {
               if (this.stores != value)
               {
                   this.stores = value;
                   NotifyPropertyChanged(p => p.Stores);
               }
           }
       }
        public Region(Int32 regionId, string regionName, string regionAddress)
        {
            this.RegionName = regionName;
            this.RegionId = regionId;
            this.RegionAddress = regionAddress;
        }
        public Region(string regionName, string regionAddress)
            : this(-1, regionName, regionAddress)
        {
           
        }
    }
}
