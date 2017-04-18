using SimpleMvvmToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Models
{
    public class ModuleClass : ModelBase<ModuleClass>
    {
        private string moduleName;
        private string moduleImage;
        private Type type;
        public ModuleClass(string moduleName,string moduleImage,Type type)
        {
            this.ModuleName = moduleName;
            this.ModuleImage = moduleImage;
            this.Type = type;
        }
        public string ModuleName
        {
            get { return this.moduleName; }
            set { this.moduleName = value; NotifyPropertyChanged(p => p.ModuleName); }
        }
        public string ModuleImage
        {
            get { return this.moduleImage; }
            set
            {
                if (this.moduleImage != value)
                {
                    this.moduleImage = value;
                    NotifyPropertyChanged(p => p.ModuleImage);
                }
            }
        }
        public Type Type
        {
            get { return this.type; }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                    NotifyPropertyChanged(p => p.Type);
                }
            }
        }
    }
}
