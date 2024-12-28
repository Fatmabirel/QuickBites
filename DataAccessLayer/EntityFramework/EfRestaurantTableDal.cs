using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfRestaurantTableDal : GenericRepository<RestaurantTable>, IRestaurantTableDal
    {
        public EfRestaurantTableDal(QuickBitesContext context) : base(context)
        {
        }

        public int TotalRestaurantTableCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.RestaurantTables.Count();
            }
        }
    }
}
