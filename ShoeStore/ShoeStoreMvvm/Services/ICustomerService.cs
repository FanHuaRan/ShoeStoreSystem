using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    /// <summary>
    /// 客户服务类
    /// </summary>
    public interface ICustomerService : IBaseEntityService<Customer>
    {
        Customer PutIfAbsent(string phone);

        Customer FindByPhone(string phone);
    }
}
