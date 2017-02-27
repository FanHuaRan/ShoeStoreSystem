using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services
{
    /// <summary>
    /// 存鞋区域服务
    /// </summary>
    public interface IRegionService : IBaseEntityService<Region>
    {
        Region FindRegionByName(string regionName);
    }
}
