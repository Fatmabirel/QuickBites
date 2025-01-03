using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void Add(Discount entity)
        {
            entity.Status = false;
           _discountDal.Add(entity);
        }
        public void ChangeStatusToFalse(int id)
        {
           _discountDal.ChangeStatusToFalse(id);
        }
        public void ChangeStatusToTrue(int id)
        {
            _discountDal.ChangeStatusToTrue(id);
        }
        public void Delete(Discount entity)
        {
            _discountDal.Delete(entity);
        }
        public List<Discount> GetAll()
        {
            return _discountDal.GetAll();
        }
        public Discount GetById(int id)
        {
            return _discountDal.GetById(id);
        }
        public List<Discount> GetListByStatusTrue()
        {
            return _discountDal.GetListByStatusTrue();
        }

        public void Update(Discount entity)
        {
            entity.Status = false;
            _discountDal.Update(entity);
        }
    }
}
