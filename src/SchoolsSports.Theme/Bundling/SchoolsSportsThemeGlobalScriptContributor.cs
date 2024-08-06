using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SchoolsSports.Theme.Bundling;

public class SchoolsSportsThemeGlobalScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        var removeFilesByNames = new[] { "/jquery.js", "select2", "fontawesome","bootstrap.bundle" };

        foreach (var fileName in removeFilesByNames)
        {
            context.Files.RemoveAll(w => w.FileName.Contains(fileName));
        }
    }
}
