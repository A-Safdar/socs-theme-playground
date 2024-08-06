using System.Linq;

namespace SchoolsSports.Theme.Themes.SchoolsSports.Components.AppVersion;

public class AppVersionViewModel
{
    public AppVersionViewModel(string fullVersion)
    {
        FullVersion = fullVersion;
        Version = FullVersion.Split('-')[0];
        SuffixVersion = FullVersion.Split('-').Last().Split('.').Last();
    }

    public string Version { get; }
    public string SuffixVersion { get; }
    public string FullVersion { get; set; }
    public bool IsBeta => FullVersion.Contains("beta");
    public bool IsAlpha => FullVersion.Contains("alpha");
}