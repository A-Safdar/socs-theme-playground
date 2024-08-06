using System.Threading.Tasks;

namespace Socs.Theme.Playground.Data;

public interface IPlaygroundDbSchemaMigrator
{
    Task MigrateAsync();
}
