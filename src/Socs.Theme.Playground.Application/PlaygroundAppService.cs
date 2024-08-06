using Socs.Theme.Playground.Localization;
using Volo.Abp.Application.Services;

namespace Socs.Theme.Playground;

/* Inherit your application services from this class.
 */
public abstract class PlaygroundAppService : ApplicationService
{
    protected PlaygroundAppService()
    {
        LocalizationResource = typeof(PlaygroundResource);
    }
}
