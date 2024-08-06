using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace SchoolsSports.Theme;

[ThemeName(Name)]
public class SchoolsSportsTheme : ITheme, ITransientDependency
{
    public const string Name = "SchoolsSports";

    public virtual string GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case StandardLayouts.Application:
                return "~/Themes/SchoolsSports/Layouts/Application.cshtml";
            case StandardLayouts.Account:
                return "~/Themes/SchoolsSports/Layouts/Account.cshtml";
            case StandardLayouts.Empty:
                return "~/Themes/SchoolsSports/Layouts/Empty.cshtml";
            default:
                return fallbackToDefault ? "~/Themes/SchoolsSports/Layouts/Application.cshtml" : null;
        }
    }
}
