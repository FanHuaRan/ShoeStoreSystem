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
        public CustomerService(CustomerManager customerManager):base()
        {
            this.entityManager = customerManager;
        }
        public Customer PutIfAbsent(string phone)
        {
            Customer customer = FindByPhone(phone);
            if (customer == null)
            {
                Customer tempCustomer = new Customer(phone,0f);
                customer = this.entityManager.Insert(tempCustomer);
            }
            return customer;
        }

        public Customer FindByPhone(string phone)
        {
            CustomerManager manager = this.entityManager as CustomerManager;
            return manager.FindCustomersByPhone(phone);
        }
    }
}
