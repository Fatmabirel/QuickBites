using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(QuickBitesContext context) : base(context)
        {
        }

        public decimal AveragePriceByHamburger()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Where(p => p.CategoryId == (context.Categories.Where(p => p.Name == "Hamburger").Select(p => p.Id).FirstOrDefault())).Average(p => p.Price);
                return values;
            }
        }

        public decimal AverageProductPrice()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Average(p => p.Price);
                return values;
            }
        }

        public List<Product> GetProductsWithCategories()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Include(c => c.Category).ToList();
                return values;
            }
        }

        public string MaximumProductPriceName()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Where(p => p.Price == (context.Products.Max(p => p.Price))).Select(P => P.Name).FirstOrDefault();
                return values;
            }
        }

        public string MinimumProductPriceName()
        {
            using (var context = new QuickBitesContext())
            {
                var values = context.Products.Where(p => p.Price == (context.Products.Min(p => p.Price))).Select(P => P.Name).FirstOrDefault();
                return values;
            }
        }

        public int ProductCount()
        {
            using (var context = new QuickBitesContext())
            {
                var totalProductCount = context.Products.Count();
                return totalProductCount;
            }
        }

        public int ProductCountByCategoryNameDrink()
        {
            using (var context = new QuickBitesContext())
            {
                var totalDrink = context.Products.Where(c => c.CategoryId == (context.Categories.Where(d => d.Name == "İçecek").Select(z => z.Id).FirstOrDefault())).Count();
                return totalDrink;
            }
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using (var context = new QuickBitesContext())
            {
                var totalDrink = context.Products.Where(c => c.CategoryId == (context.Categories.Where(d => d.Name == "Hamburger").Select(z => z.Id).FirstOrDefault())).Count();
                return totalDrink;
            }
        }
    }
}
