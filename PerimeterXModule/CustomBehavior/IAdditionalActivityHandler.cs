using System.Web;

namespace PerimeterX.CustomBehavior
{
    public interface IAdditionalActivityHandler
    {
        void Handle(HttpRequest httpRequest, PxModuleConfigurationSection pxConfig, PxContext pxContext);
    }
}
