using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ITTP.Persistance
{
    class ITTPDbContextFactory : IDesignTimeDbContextFactory<ITTPDbContext>
    {
        public ITTPDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ITTPDbContext>();

            string connectionString = @"server=.\sqlexpress;database=TestDB;
                    integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            optionsBuilder.UseSqlServer(connectionString);

            return new ITTPDbContext(optionsBuilder.Options);
        }
    }
}
