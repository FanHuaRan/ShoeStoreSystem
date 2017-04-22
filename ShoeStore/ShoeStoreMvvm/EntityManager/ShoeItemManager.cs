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
        public IEnumerable<ShoeItem> FindNoSellShoeItems()
        {
            return context.ShoeItems
                .Include(p => p.Shoe)
                .Include(p=>p.Order)
                .Where(p => p.IsSell == 0)
                .ToList();
        }

        public IEnumerable<ShoeItem> FindSellShoeItems()
        {
            return context.ShoeItems
                .Include(p => p.Shoe)
                .Include(p => p.Order)
                .Where(p => p.IsSell == 1)
                .ToList();
        }

        public IEnumerable<ShoeItem> FindSellShoeItemsByYear(int year)
        {
            var minTime = new DateTime(year, 01, 01);
            var maxTime = new DateTime(year + 1, 01, 01);
            return context.ShoeItems
                            .Include(p => p.Shoe)
                            .Include(p => p.Order)
                           .Where(p => p.IsSell == 1
                           && p.Order.SaleTime >= minTime
                           && p.Order.SaleTime < maxTime)
                          .ToList();
        }

        public IEnumerable<ShoeItem> FindSellShoeItemsByMonth(int year, int month)
        {
            var minTime = new DateTime(year, month, 01);
            var maxTime = new DateTime(year, month + 1, 01);
            return context.ShoeItems
                          .Include(p => p.Shoe)
                          .Include(p => p.Order)
                          .Where(p => p.IsSell == 1&& p.Order.SaleTime >= minTime && p.Order.SaleTime < maxTime)
                         .ToList();
        }

        public IEnumerable<ShoeItem> FindSellShoeItems(string phone)
        {
            return context.ShoeItems
                .Include(p => p.Shoe)
                .Include(p => p.Order)
                .Where(p => p.IsSell == 1&& p.Order.Customer.Phone == phone)
                .ToList();
        }
        public override IEnumerable<ShoeItem> FindAll()
        {
            return context.Set<ShoeItem>()
                .Include(p => p.Shoe)
                .Include(p => p.Order)
                .Select(p => p)
                .ToList<ShoeItem>();
        }
        public override IEnumerable<ShoeItem> SimpleCompositeFind(params Func<ShoeItem, bool>[] delegates)
        {
            if (delegates.Length == 0)
            {
                return new List<ShoeItem>();
            }
            var objects = context.Set<ShoeItem>()
                .Include(p=>p.Shoe)
                .Include(p=>p.Order)
                .Where(delegates[0])
                .Select(p => p);
            for (int i = 1; i < delegates.Length; i++)
            {
                var condition = delegates[i];
                objects = objects.Where(condition).Select(p => p).AsQueryable<ShoeItem>();
            }
            return objects.ToList();
        }
    }
}
