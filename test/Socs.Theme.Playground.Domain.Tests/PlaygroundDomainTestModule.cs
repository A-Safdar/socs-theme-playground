using Volo.Abp.Modularity;

namespace Socs.Theme.Playground;

[DependsOn(
    typeof(PlaygroundDomainModule),
    typeof(PlaygroundTestBaseModule)
)]
public class PlaygroundDomainTestModule : AbpModule
{

}
