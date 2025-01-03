using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(QuickBitesContext context) : base(context)
        {
        }
        public void ChangeStatusToFalse(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var discount = context.Discounts.Find(id);
                discount.Status = false;
                context.SaveChanges();
            }
        }
        public void ChangeStatusToTrue(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var discount = context.Discounts.Find(id);
                discount.Status = true;
                context.SaveChanges();
            }
        }
        public List<Discount> GetListByStatusTrue()
        {
            using (var context = new QuickBitesContext())
            {
                var discount = context.Discounts.Where(d=>d.Status == true).ToList();
                return discount;
            }
        }
    }
}
