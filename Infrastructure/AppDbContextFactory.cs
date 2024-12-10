using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data;
using System.IO;

namespace Infrastructure
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Set an absolute path to the WebUI project's appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Points to the Infrastructure project directory
                .AddJsonFile(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "WebUI", "appsettings.json"))  // Absolute path to WebUI's appsettings.json
                .Build();

            // Set up DbContextOptions using the configuration
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySQL(config.GetConnectionString("Default"));

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
