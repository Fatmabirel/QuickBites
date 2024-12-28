using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(QuickBitesContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Orders.Where(o => o.Description == "Müşteri Masada").Count();
            }
        }

        public decimal LastOrderPrice()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Orders.OrderByDescending(o => o.Id).Take(1).Select(o => o.TotalPrice).FirstOrDefault(); ;
            }
        }

        public int PassiveOrderCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Orders.Where(o => o.Description == "Müşteri Masada Değil").Count();
            }
        }

        public decimal TodayTotalPrice()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Orders.Where(o => o.OrderDate.Date == DateTime.Today).Sum(o=>o.TotalPrice);
            }
        }

        public int TotalOrderCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Orders.Count();
            }
        }
    }
}
