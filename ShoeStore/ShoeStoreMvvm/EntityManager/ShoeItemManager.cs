using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    class ShoeItemManager : EntityBaseManager<ShoeItem>, IEntityManager<ShoeItem>
    {
        public DbSet<ShoeItem> ShoeItems
        {
            get { return context.ShoeItems; }
        }
        public List<ShoeItem> FindNoSellShoeItems()
        {
            return context.ShoeItems
                .Where(p => p.IsSell == 0)
                .ToList();
        }

        public List<ShoeItem> FindSellShoeItems()
        {
            return context.ShoeItems
                .Where(p => p.IsSell == 1)
                .ToList();
        }

        public List<ShoeItem> FindSellShoeItemsByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year + 1, 01, 01);
            return context.ShoeItems
                           .Where(p => p.IsSell == 1
                           && p.Order.SaleTime >= minTime
                           && p.Order.SaleTime < maxTime)
                          .ToList();
        }

        public List<ShoeItem> FindSellShoeItemsByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return context.ShoeItems
                          .Where(p => p.IsSell == 1
                          && p.Order.SaleTime >= minTime
                          && p.Order.SaleTime < maxTime)
                         .ToList();
        }

        public List<ShoeItem> FindSellShoeItems(string phone)
        {
            return context.ShoeItems
                .Where(p => p.IsSell == 1
                && p.Order.Customer.Phone == phone)
              .ToList();
        }
    }
}
