using JetBrains.Annotations;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SchoolsSports.Theme;

public interface ISchoolsSportsBrandingProvider : IBrandingProvider, ITransientDependency
{
    [CanBeNull] string LogoSmallUrl { get; }
    [CanBeNull] string HeaderTagLine { get; }
}