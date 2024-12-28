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
            _restaurantTableDal.Update(entity);
        }
    }
}
