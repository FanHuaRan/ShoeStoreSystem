using ShoeStoreMvvm.Models;
using ShoeStoreMvvm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreMvvm.Services
{
    /// <summary>
    /// 季节服务
    /// </summary>
    public interface ISeasonService:IBaseEntityService<Season>
    {
        Season FindSeasonByName(string seasonName);
    }
}
