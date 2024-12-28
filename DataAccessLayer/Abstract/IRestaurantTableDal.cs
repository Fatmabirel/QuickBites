using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IRestaurantTableDal : IGenericDal<RestaurantTable>
    {
        int TotalRestaurantTableCount();
    }
}
