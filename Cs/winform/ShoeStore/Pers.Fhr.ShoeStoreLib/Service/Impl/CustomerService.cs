using Pers.Fhr.ShoeStoreLib.Entity;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// CustomerService实现
    /// </summary>
    class CustomerService 
        : AbstractEntityBaseClass<Customer, CustomerService>,
        ICustomerService
    {
        private CustomerService(CustomerManager customerManager):base()
        {
            this.entityManager = customerManager;
        }
        public override CustomerService CreateSingleInstance()
        {
            if (this.instance == null)
            {
                this.instance= new CustomerService(CustomerManager.Instance);
            }
            return instance;
        }
    }
}
