using Microsoft.Practices.Unity;
using VirtoCommerce.Platform.Core.Modularity;

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
        }
    }
}