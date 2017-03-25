using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pers.Fhr.ShoeStoreLib.Component;
using ShoeStoreMvvm.Models;
namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Customer管理类
    /// 2017/02/05 fhr
    /// </summary>
    class CustomerManager : EntityBaseManager<Customer>, IEntityManager<Customer>
    {
        public List<Customer> FindCustomersByScoreIntervel(float min, float max)
        {
            return this.context.Customers.
                Where(p => p.Score >= min && p.Score <= max).
                ToList();
        }
        public Customer FindCustomersByPhone(string phone)
        {
            return this.context.Customers.
                Where(p => p.Phone == phone)
                .FirstOrDefault();
        }
        public CustomerManager():base()
        {

        }
    }
}
