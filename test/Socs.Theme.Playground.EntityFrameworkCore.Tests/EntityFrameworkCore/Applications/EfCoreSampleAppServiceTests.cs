using Socs.Theme.Playground.Samples;
using Xunit;

namespace Socs.Theme.Playground.EntityFrameworkCore.Applications;

[Collection(PlaygroundTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PlaygroundEntityFrameworkCoreTestModule>
{

}
