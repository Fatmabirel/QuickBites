using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(QuickBitesContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Categories.Where(c => c.Status == true).Count();
            }
        }

        public int CategoryCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Categories.Count();
            }
        }

        public int PassiveCategoryCount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.Categories.Where(c => c.Status == false).Count();
            }
        }
    }
}
