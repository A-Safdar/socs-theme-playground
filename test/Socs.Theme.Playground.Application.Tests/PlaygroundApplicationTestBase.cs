using Volo.Abp.Modularity;

namespace Socs.Theme.Playground;

public abstract class PlaygroundApplicationTestBase<TStartupModule> : PlaygroundTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
