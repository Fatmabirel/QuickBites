using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
        int PassiveOrderCount();
        decimal LastOrderPrice();
    }
}
