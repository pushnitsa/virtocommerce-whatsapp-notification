using VirtoCommerce.Platform.Core.Notifications;
using VirtoCommerce.WhatsAppNotification.Core.Gateway;

namespace VirtoCommerce.WhatsAppNotification.Core.Notifications
{
    public class WhatsAppNotification : Notification
    {
        public WhatsAppNotification(IWhatsAppNotificationSendingGateway notificationSendingGateway) 
            : base(notificationSendingGateway)
        {
        }
    }
}
