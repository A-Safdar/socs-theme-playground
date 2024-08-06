using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Socs.Theme.Playground.Web;

[Dependency(ReplaceServices = true)]
public class PlaygroundBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Playground";
}
