using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public decimal AveragePriceByHamburger()
        {
            return _productDal.AveragePriceByHamburger();
        }

        public decimal AverageProductPrice()
        {
            return _productDal.AverageProductPrice();
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public string MaximumProductPriceName()
        {
            return _productDal.MaximumProductPriceName();
        }

        public string MinimumProductPriceName()
        {
            return _productDal.MinimumProductPriceName();
        }

        public int ProductCount()
        {
            return _productDal.ProductCount();
        }

        public int ProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
