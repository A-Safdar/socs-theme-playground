using Xunit;

namespace Socs.Theme.Playground.EntityFrameworkCore;

[CollectionDefinition(PlaygroundTestConsts.CollectionDefinitionName)]
public class PlaygroundEntityFrameworkCoreCollection : ICollectionFixture<PlaygroundEntityFrameworkCoreFixture>
{

}
