using System.Web;

namespace PerimeterX.CustomBehavior
{
    /// <summary>
    /// Additional activity handler, invoked after the page_requested/block activity was reported
    /// and before the request continues. Intended for observability only - it cannot change the
    /// enforcement decision, and exceptions thrown from it are swallowed by the module.
    /// The instance is created once and reused across requests, so implementations must be thread safe.
    /// </summary>
    public interface IAdditionalActivityHandler
    {
        void Handle(HttpRequest httpRequest, PxModuleConfigurationSection pxConfig, PxContext pxContext);
    }
}
