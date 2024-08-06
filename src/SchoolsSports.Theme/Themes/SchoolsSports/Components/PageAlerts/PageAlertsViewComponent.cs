using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.PageAlerts;

public class PageAlertsViewComponent(IAlertManager alertManager) : AbpViewComponent
{
    protected IAlertManager AlertManager { get; } = alertManager;

    public IViewComponentResult Invoke(string name)
    {
        return View("~/Themes/SchoolsSports/Components/PageAlerts/Default.cshtml", AlertManager.Alerts);
    }
}
