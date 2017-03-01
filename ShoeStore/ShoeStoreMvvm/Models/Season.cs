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
    /// 季节实体
    /// 2017/2/4 fhr
    /// </summary>
    public class Season:ModelBase<Season>
    {
        private int seasonId;
        private string seasonName;
        private virtual List<Shoe> shoes;

        [PrimaryKeyAttribute]
        public Int32 SeasonId
        {
            get { return this.seasonId; }
            set { this.seasonId = value; NotifyPropertyChanged(p => p.SeasonId); }
        }

        public string SeasonName
        {
            get { return this.seasonName; }
            set { this.seasonName = value; NotifyPropertyChanged(p => p.SeasonName); }
        }
        public virtual List<Shoe> Shoes
        {
            get { return this.shoes; }
            set { this.shoes = value; NotifyPropertyChanged(p => p.Shoes); }
        }
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
