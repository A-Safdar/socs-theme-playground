using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Toolbar.Login;

public class LoginViewComponent(IMenuManager menuManager) : AbpViewComponent
{
    protected IMenuManager MenuManager { get; } = menuManager;

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/SchoolsSports/Components/Toolbar/Login/Default.cshtml");
    }
}
