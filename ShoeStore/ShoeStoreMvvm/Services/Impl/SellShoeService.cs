using Pers.Fhr.ShoeStoreLib.Entity;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using Pers.Fhr.ShoeStoreLib.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    /// <summary>
    /// 销售服务
    /// </summary>
    class SellShoeService
        :AbstractEntityBaseClass<Sale,SellShoeService>
         ,ISellShoeService
    {
        
        private readonly IShoeService shoeService;
        private readonly ICustomerService customerService;
        public IScoreCheapStrategey ScoreCheapStrategey
        {
            get;
            set;
        }

        public IScoreEarnStrategey ScoreEarnStrategey
        {
            get;
            set;
        }

        public Entity.Sale SellShoe(DateTime saleTime, List<Entity.Shoe> selledShoes, string phone)
        {
            float totalPrice=selledShoes.Sum(p=>p.SellPrice).Value;
            Customer customer=GetCustomer(phone);
            long? customerId=null;
            if(customer!=null){
                customerId=customer.CustomerId;
            }
            Sale tempSale = new Sale(customerId, saleTime, totalPrice);
            if(customer!=null)
            {
                //没有扣积分。。。。
                float cheapMoney = ScoreCheapStrategey.CheapMoney(customer, tempSale);
                tempSale.TotalPrice -= cheapMoney;
                float addScore = ScoreEarnStrategey.EarnScore(customer, tempSale);
            }
            Sale sale = this.entityManager.Insert(tempSale);
            UpdateShoes(selledShoes, sale);
            return sale;
        }

        private void UpdateShoes(List<Entity.Shoe> selledShoes, Sale sale)
        {
            selledShoes.ForEach(shoe =>
            {
                shoe.SaleId = sale.SaleId;
                shoe.IsSell = 1;
                shoeService.Update(shoe);
            });
        }
        private Customer GetCustomer(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return null;
            }
            Customer customer=customerService.FindByPhone(phone);
            if (customer == null)
            {
                customer=customerService.PutIfAbsent(phone);
            }
            return customer;
        }
        public SellShoeService(SaleManager saleManager,IShoeService shoeService, ICustomerService customerService)
        {
            this.entityManager = saleManager;
            this.shoeService = shoeService;
            this.customerService = customerService;
        }
    }
}
