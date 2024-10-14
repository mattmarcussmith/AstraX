using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AstraX.Dal.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        /*
           The ApplicationDbContextFactory enables migrations to occur at Design Time.
           Because the API project is another project, manual config to point to DBContext is required
           for design time use.

           This is where (ApplicationDbContextFactory) is necessary.
         */

        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../AstraX.Api");

        var configurationRoot = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        var connectionString = configurationRoot.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);


        return new ApplicationDbContext(optionsBuilder.Options);
    }
}