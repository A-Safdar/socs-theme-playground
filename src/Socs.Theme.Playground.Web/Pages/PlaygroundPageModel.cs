using Socs.Theme.Playground.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Socs.Theme.Playground.Web.Pages;

public abstract class PlaygroundPageModel : AbpPageModel
{
    protected PlaygroundPageModel()
    {
        LocalizationResourceType = typeof(PlaygroundResource);
    }
}
