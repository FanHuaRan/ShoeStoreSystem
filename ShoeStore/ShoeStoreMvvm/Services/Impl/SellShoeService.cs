using Pers.Fhr.ShoeStoreLib.EntityManager;
using ShoeStoreMvvm.Models;
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
        :AbstractEntityBaseClass<Order>
         ,ISellShoeService
    {

        private readonly IShoeItemService shoeItemService;
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

        public Order SellShoe(DateTime saleTime, List<ShoeItem> selledShoes, string phone)
        {
            float totalPrice=selledShoes.Sum(p=>p.SellPrice).Value;
            Customer customer=GetCustomer(phone);
            long? customerId=null;
            if(customer!=null){
                customerId=customer.CustomerId;
            }
            Order tempSale = new Order(customerId, saleTime, totalPrice);
            if(customer!=null)
            {
                //没有扣积分。。。。
                float cheapMoney = ScoreCheapStrategey.CheapMoney(customer, tempSale);
                tempSale.TotalPrice -= cheapMoney;
                float addScore = ScoreEarnStrategey.EarnScore(customer, tempSale);
            }
            Order order = this.entityManager.Insert(tempSale);
            UpdateShoeItems(selledShoes, order);
            return order;
        }

        private void UpdateShoeItems(List<ShoeItem> selledShoes, Order order)
        {
            selledShoes.ForEach(shoe =>
            {
                shoe.OrderId = order.OrderId;
                shoe.IsSell = 1;
                shoeItemService.Update(shoe);
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
        public SellShoeService(OrderManager OorderManager, IShoeItemService shoeItemService, ICustomerService customerService)
        {
            this.entityManager = OorderManager;
            this.shoeItemService = shoeItemService;
            this.customerService = customerService;
        }
    }
}
