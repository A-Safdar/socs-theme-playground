using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Toolbar;

public class HeaderToolbarViewComponent(IToolbarManager toolbarManager) : AbpViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var toolbar = await toolbarManager.GetAsync(StandardToolbars.Main);
        return View("~/Themes/SchoolsSports/Components/Toolbar/Default.cshtml", toolbar);
    }
}
