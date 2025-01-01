using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        int NotificationCountByStatusFalse();
        List<Notification> GetAllNotificationsByStatusFalse();
        void NotificationStatusChangeToTrue(int id);
        void NotificationStatusChangeToFalse(int id);
    }
}
