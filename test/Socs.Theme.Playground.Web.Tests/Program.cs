using Microsoft.AspNetCore.Builder;
using Socs.Theme.Playground;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<PlaygroundWebTestModule>();

public partial class Program
{
}
