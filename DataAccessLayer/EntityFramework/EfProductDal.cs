using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(QuickBitesContext context) : base(context)
        {
        }
        public List<Product> GetProductsWithCategories()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Include(c => c.Category).ToList();
                return values;
            }
        }
    }
}
