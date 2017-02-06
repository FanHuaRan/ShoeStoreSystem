using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pers.Fhr.ShoeStoreLib.Component;
using Pers.Fhr.ShoeStoreLib.Entity;
namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Customer管理类
    /// 2017/02/05 fhr
    /// </summary>
    class CustomerManager : EntityBaseManager<Customer>, IEntityManager<Customer>
    {
        public IList<Customer> FindCustomersByScoreIntervel(float min, float max)
        {
            return this.context.Customers.
                Where(p => p.Score >= min && p.Score <= max).
                ToList()
                as IList<Customer>;
        }
        public IList<Customer> FindCustomersByName(string name)
        {
            return this.context.Customers.
                Where(p => p.CustomerName==name).
                ToList()
                as IList<Customer>;
        }
        public IList<Customer> FindCustomersByPhone(string phone)
        {
            return this.context.Customers.
                Where(p => p.Phone == phone).
                ToList()
                as IList<Customer>;
        }
        private CustomerManager():base()
        {

        }
        private static CustomerManager instance = null;
        public static CustomerManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerManager();
                }
                return instance;
            }
        }
    }
}
