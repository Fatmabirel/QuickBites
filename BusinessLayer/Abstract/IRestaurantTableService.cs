using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IRestaurantTableService : IGenericService<RestaurantTable>
    {
        int TotalRestaurantTableCount();
    }
}
