using Socs.Theme.Playground.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Socs.Theme.Playground.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PlaygroundEntityFrameworkCoreModule),
    typeof(PlaygroundApplicationContractsModule)
)]
public class PlaygroundDbMigratorModule : AbpModule
{
}
