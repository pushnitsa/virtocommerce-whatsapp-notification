using Microsoft.Practices.Unity;
using VirtoCommerce.Platform.Core.Modularity;
using VirtoCommerce.Platform.Core.Notifications;
using VirtoCommerce.WhatsAppNotification.Core.Gateway;
using VirtoCommerce.WhatsAppNotification.Data.WhatsAppClient;
using VirtoCommerce.WhatsAppNotification.Web.Gateway;

namespace VirtoCommerce.WhatsAppNotification.Web
{
    public class Module : ModuleBase
    {
        private readonly IUnityContainer _container;

        public Module(IUnityContainer container)
        {
            _container = container;
        }

        public override void Initialize()
        {
            base.Initialize();

            _container.RegisterType<IWhatsAppNotificationSendingGateway, WhatsAppNotificationSendingGateway>();
            _container.RegisterType<WooWaClient>();

            var notificationManager = _container.Resolve<INotificationManager>();

            notificationManager.RegisterNotificationType(() => new Core.Notifications.WhatsAppNotification(_container.Resolve<IWhatsAppNotificationSendingGateway>())
            {
                DisplayName = "WhatsApp notification",
                Description = "",
                NotificationTemplate = new NotificationTemplate
                {
                    Body = "Sample notification body."
                }
            });
        }
    }
}
