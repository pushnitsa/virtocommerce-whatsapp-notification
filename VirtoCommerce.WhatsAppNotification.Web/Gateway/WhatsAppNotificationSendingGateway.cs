using VirtoCommerce.Platform.Core.Notifications;
using VirtoCommerce.WhatsAppNotification.Core.Gateway;
using VirtoCommerce.WhatsAppNotification.Data.WhatsAppClient;

namespace VirtoCommerce.WhatsAppNotification.Web.Gateway
{
    public class WhatsAppNotificationSendingGateway : IWhatsAppNotificationSendingGateway
    {
        private readonly WooWaClient _client;

        public WhatsAppNotificationSendingGateway(WooWaClient client)
        {
            _client = client;
        }

        public SendNotificationResult SendNotification(Notification notification)
        {
            var result = new SendNotificationResult();

            _client.SendMessage(notification.Recipient, notification.Body);

            result.IsSuccess = true;

            return result;
        }

        public bool ValidateNotification(Notification notification)
        {
            return !string.IsNullOrEmpty(notification.Recipient) &&
                   !string.IsNullOrEmpty(notification.Body);
        }
    }
}
