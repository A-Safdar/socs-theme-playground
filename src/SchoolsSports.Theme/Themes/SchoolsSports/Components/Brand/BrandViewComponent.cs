using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Brand;

public class BrandViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/SchoolsSports/Components/Brand/Default.cshtml");
    }
}
