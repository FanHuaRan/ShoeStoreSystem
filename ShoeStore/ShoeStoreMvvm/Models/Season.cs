﻿using Pers.Fhr.ShoeStoreLib.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    /// <summary>
    /// 季节实体
    /// 2017/2/4 fhr
    /// </summary>
    public class Season
    {
        [PrimaryKeyAttribute]
        public Int32 SeasonId { get; set; }

        public string SeasonName { get; set; }

        public Season(Int32 seasonId, string seasonName)
        {
            this.SeasonId = seasonId;
            this.SeasonName = seasonName;
        }
        public Season(string seasonName)
        {
            this.SeasonName = seasonName;
        }
    }
}