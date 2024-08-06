using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Header;

public class HeaderViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/SchoolsSports/Components/Header/Version2.cshtml");
    }
}
