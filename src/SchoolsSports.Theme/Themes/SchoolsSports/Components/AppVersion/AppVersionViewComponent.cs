using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.AppVersion;

public class AppVersionViewComponent : AbpViewComponent
{
    public IViewComponentResult Invoke()
    {
        var fullVersion = GetInformationalVersion();

        var model = new AppVersionViewModel(fullVersion);
        return View("~/Themes/SchoolsSports/Components/AppVersion/Default.cshtml", model);
    }

    private static string GetAppVersion()
    {
        var version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString();
        return version ?? "Unknown";
    }

    private static string GetInformationalVersion()
    {
        var attributes = Assembly.GetExecutingAssembly()
            .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
        return attributes.Length > 0
            ? ((AssemblyInformationalVersionAttribute)attributes[0]).InformationalVersion
            : GetAppVersion();
    }
}