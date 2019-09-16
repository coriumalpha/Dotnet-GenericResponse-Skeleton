using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Gaia.Data.Models;


namespace Gaia.Data
{
    public class SJewContextFactory : IDesignTimeDbContextFactory<GaiaContext>
    {
        public GaiaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GaiaContext>();
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SJewDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            return new GaiaContext(optionsBuilder.Options);
        }
    }
}
