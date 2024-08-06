using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SchoolsSports.Theme.Bundling;

public class SchoolsSportsThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        var removeFilesByNames = new[] { "bootstrap", "fontawesome", "select2" };

        foreach (var fileName in removeFilesByNames)
        {
            context.Files.RemoveAll(w => w.FileName.Contains(fileName));
        }
    }
}