using Pers.Fhr.ShoeStoreLib.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// Shoe管理类
    /// 2017/02/06 fhr
    /// </summary>
    class ShoeManager : EntityBaseManager<Shoe>, IEntityManager<Shoe>
    {
        public DbSet<Shoe> Shoes
        {
            get { return context.Shoes; }
        }
        public IList<Shoe> FindNoSellShoes()
        {
          return  context.Shoes
              .Where(p => p.IsSell == 0)
              .ToList();
        }

        public IList<Shoe> FindSellShoes()
        {
            return context.Shoes
                .Where(p => p.IsSell == 1)
                .ToList();
        }

        public IList<Shoe> FindSellShoesByYear(int year)
        {
            DateTime minTime = new DateTime(year, 01, 01);
            DateTime maxTime = new DateTime(year + 1, 01, 01);
            return context.Shoes
                           .Where(p => p.IsSell == 1
                           && p.Sale.SaleTime >= minTime
                           && p.Sale.SaleTime < maxTime)
                          .ToList();
        }

        public IList<Shoe> FindSellShoesByMonth(int year, int month)
        {
            DateTime minTime = new DateTime(year, month, 01);
            DateTime maxTime = new DateTime(year, month + 1, 01);
            return context.Shoes
                          .Where(p => p.IsSell == 1
                          && p.Sale.SaleTime >= minTime
                          && p.Sale.SaleTime < maxTime)
                         .ToList();
        }

        public IList<Shoe> FindSellShoes(string phone)
        {
            return context.Shoes
                .Where(p => p.IsSell == 1
                && p.Sale.Customer.Phone == phone)
              .ToList();
        }
        public ShoeManager()
            : base()
        {

        }
    }
}
