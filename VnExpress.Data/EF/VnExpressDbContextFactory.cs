using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VnExpress.Data.EF
{
    public class VnExpressDbContextFactory : IDesignTimeDbContextFactory<VnExpressDbContext>
    {
        public VnExpressDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("VnExpressDb");

        var optionsBuilder = new DbContextOptionsBuilder<VnExpressDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new VnExpressDbContext(optionsBuilder.Options);
    }
}

}
