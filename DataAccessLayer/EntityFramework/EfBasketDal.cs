using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(QuickBitesContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByRestaurantTableId(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Baskets.Where(b => b.RestaurantTableId == id).Include(b=>b.Product).ToList();
                return values;
            }
        }

        public List<Basket> GetBasketWithProductName(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Baskets.Include(c => c.Product).Where(c => c.RestaurantTableId == id).ToList();
                return values;
            }
        }
    }
}
