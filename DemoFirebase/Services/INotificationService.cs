using DemoFirebase.Models;

namespace DemoFirebase.Services
{
    public interface INotificationService
    {
        Task<ResponseModel> SendNotification(NotificationModel notificationModel);
    }
}
