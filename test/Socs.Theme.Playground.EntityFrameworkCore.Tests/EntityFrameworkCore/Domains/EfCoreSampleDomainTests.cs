using Socs.Theme.Playground.Samples;
using Xunit;

namespace Socs.Theme.Playground.EntityFrameworkCore.Domains;

[Collection(PlaygroundTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PlaygroundEntityFrameworkCoreTestModule>
{

}
