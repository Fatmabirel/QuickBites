using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class RestaurantTableManager : IRestaurantTableService
    {
        private readonly IRestaurantTableDal _restaurantTableDal;
        public RestaurantTableManager(IRestaurantTableDal restaurantTableDal)
        {
            _restaurantTableDal = restaurantTableDal;
        }
        public void Add(RestaurantTable entity)
        {
            entity.Status = true;
            _restaurantTableDal.Add(entity);
        }

        public void Delete(RestaurantTable entity)
        {
            _restaurantTableDal.Delete(entity);
        }

        public List<RestaurantTable> GetAll()
        {
            return _restaurantTableDal.GetAll();
        }

        public RestaurantTable GetById(int id)
        {
           return _restaurantTableDal.GetById(id);
        }

        public int TotalRestaurantTableCount()
        {
            return _restaurantTableDal.TotalRestaurantTableCount();
        }

        public void Update(RestaurantTable entity)
        {
            entity.Status = true;
            _restaurantTableDal.Update(entity);
        }
    }
}
