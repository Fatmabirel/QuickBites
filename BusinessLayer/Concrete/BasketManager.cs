using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void Add(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void Delete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public List<Basket> GetAll()
        {
            return _basketDal.GetAll();
        }

        public List<Basket> GetBasketByRestaurantTableId(int id)
        {
            return _basketDal.GetBasketByRestaurantTableId(id);
        }

        public List<Basket> GetBasketWithProductName(int id)
        {
            return _basketDal.GetBasketWithProductName(id);
        }

        public Basket GetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public void Update(Basket entity)
        {
            _basketDal.Update(entity);
        }
    }
}
