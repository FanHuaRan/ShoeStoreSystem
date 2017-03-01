﻿using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services
{
    public interface IModuleServiceAgent
    {
        ObservableCollection<ModuleClass> GetModuleList();
    }
}
