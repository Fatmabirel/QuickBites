using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(QuickBitesContext context) : base(context)
        {
        }
        public decimal TotalMoneyCaseAmount()
        {
            using (var context = new QuickBitesContext())
            {
                return context.MoneyCases.Select(m => m.TotalAmount).FirstOrDefault();
            }
        }
    }
}
