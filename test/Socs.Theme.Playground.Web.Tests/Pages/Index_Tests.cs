using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Socs.Theme.Playground.Pages;

[Collection(PlaygroundTestConsts.CollectionDefinitionName)]
public class Index_Tests : PlaygroundWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
