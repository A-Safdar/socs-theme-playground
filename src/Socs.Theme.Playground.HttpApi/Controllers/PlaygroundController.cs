using Socs.Theme.Playground.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Socs.Theme.Playground.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PlaygroundController : AbpControllerBase
{
    protected PlaygroundController()
    {
        LocalizationResource = typeof(PlaygroundResource);
    }
}
