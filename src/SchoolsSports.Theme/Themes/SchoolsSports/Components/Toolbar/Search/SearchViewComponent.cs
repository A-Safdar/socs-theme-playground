using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.Toolbar.Search;

public class SearchViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/SchoolsSports/Components/Toolbar/Search/Default.cshtml");
    }
}
