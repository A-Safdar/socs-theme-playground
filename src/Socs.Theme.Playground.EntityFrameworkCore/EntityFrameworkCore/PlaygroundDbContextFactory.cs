using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Socs.Theme.Playground.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PlaygroundDbContextFactory : IDesignTimeDbContextFactory<PlaygroundDbContext>
{
    public PlaygroundDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        PlaygroundEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<PlaygroundDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new PlaygroundDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Socs.Theme.Playground.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
