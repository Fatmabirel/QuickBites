using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
        List<Discount> GetListByStatusTrue();
    }
}
