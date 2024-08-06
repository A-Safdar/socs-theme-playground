using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Toolbar.UserMenu;

public class UserMenuViewComponent(IMenuManager menuManager) : AbpViewComponent
{
    protected IMenuManager MenuManager { get; } = menuManager;

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetAsync(StandardMenus.User);
        return View("~/Themes/SchoolsSports/Components/Toolbar/UserMenu/Default.cshtml", menu);
    }
}
