using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Layout;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.ContentTitle;

public class ContentTitleViewComponent(IPageLayout pageLayout) : AbpViewComponent
{
    protected IPageLayout PageLayout { get; } = pageLayout;

    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/SchoolsSports/Components/ContentTitle/Default.cshtml", PageLayout.Content);
    }
}
