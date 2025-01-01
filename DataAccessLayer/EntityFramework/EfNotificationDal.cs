using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(QuickBitesContext context) : base(context)
        {
        }

        public List<Notification> GetAllNotificationsByStatusFalse()
        {
            using (var context = new QuickBitesContext())
            {
                var allNotificationsByStatustFalse = context.Notifications.Where(n => n.Status == false).ToList();
                return allNotificationsByStatustFalse;
            }
        }

        public int NotificationCountByStatusFalse()
        {
            using (var context = new QuickBitesContext())
            {
                var notificationCount = context.Notifications.Where(n => n.Status == false).Count();
                return notificationCount;
            }
        }

        public void NotificationStatusChangeToFalse(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var notification = context.Notifications.Find(id);
                notification.Status = false;
                context.SaveChanges();
            }
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            using (var context = new QuickBitesContext())
            {
                var notification = context.Notifications.Find(id);
                notification.Status = true;
                context.SaveChanges();
            }
        }
    }
}
