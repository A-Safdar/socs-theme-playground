using Volo.Abp.Modularity;

namespace Socs.Theme.Playground;

[DependsOn(
    typeof(PlaygroundApplicationModule),
    typeof(PlaygroundDomainTestModule)
)]
public class PlaygroundApplicationTestModule : AbpModule
{

}
