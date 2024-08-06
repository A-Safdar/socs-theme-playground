using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SchoolsSports.Theme.Themes.SchoolsSports.Components.Toolbar.UserMenu;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Localization;
using Volo.Abp.Users;

namespace SchoolsSports.Theme.Toolbars;

public class SchoolsSportsThemeMainTopToolbarContributor : IToolbarContributor
{
    public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name != StandardToolbars.Main)
        {
            return;
        }

        if (context.Theme is not SchoolsSportsTheme)
        {
            return;
        }

        var userLoginLink =
            context.Toolbar.Items.FirstOrDefault(f => f.ComponentType.Name == "UserLoginLinkViewComponent");
        if (userLoginLink != null)
        {
            context.Toolbar.Items.Remove(userLoginLink);
        }


        //context.Toolbar.Items.Add(new ToolbarItem(typeof(SearchViewComponent)));

        var languageProvider = context.ServiceProvider.GetService<ILanguageProvider>();

        //TODO: This duplicates GetLanguages() usage. Can we eleminate this?
        var languages = await languageProvider.GetLanguagesAsync();
        if (languages.Count > 1)
        {
            //context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));
        }

        if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
        }
            
    }
}