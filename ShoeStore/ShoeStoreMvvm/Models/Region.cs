﻿using Pers.Fhr.ShoeStoreLib.Component;
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
   public class Region
    {
        [PrimaryKeyAttribute]
        public Int32 RegionId { get; set; }

        public string RegionName { get; set; }

        public string RegionAddress { get; set; }

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