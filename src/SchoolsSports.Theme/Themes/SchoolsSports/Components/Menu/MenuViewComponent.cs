using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Features;
using Volo.Abp.UI.Navigation;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Menu;

public class MenuViewComponent(IMenuManager menuManager) : AbpViewComponent
{
    protected IMenuManager MenuManager { get; } = menuManager;

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetMainMenuAsync();
        
        return View("~/Themes/SchoolsSports/Components/Menu/Version2.cshtml", menu);
    }
}
