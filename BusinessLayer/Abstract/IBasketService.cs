using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> GetBasketByRestaurantTableId(int id);
        List<Basket> GetBasketWithProductName(int id);
    }
}
