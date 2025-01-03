using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(QuickBitesContext context) : base(context)
        {
        }
        public void BookingStatusApproved(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var booking = context.Bookings.Find(id);
                booking.Description = "Rezervasyon Onaylandı";
                context.SaveChanges();
            }
        }
        public void BookingStatusCancelled(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var booking = context.Bookings.Find(id);
                booking.Description = "Rezervasyon İptal Edildi";
                context.SaveChanges();
            }
        }
    }
}
