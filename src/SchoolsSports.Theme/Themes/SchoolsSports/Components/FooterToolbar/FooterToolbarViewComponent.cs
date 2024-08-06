using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolsSports.Theme.Toolbars;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.FooterToolbar;

public class FooterToolbarViewComponent(IToolbarManager toolbarManager) : AbpViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync()
    {    
        var toolbar = await toolbarManager.GetAsync(SchoolsSportsToolbars.Footer);

        return View("~/Themes/SchoolsSports/Components/FooterToolbar/Default.cshtml",toolbar);
    }
}