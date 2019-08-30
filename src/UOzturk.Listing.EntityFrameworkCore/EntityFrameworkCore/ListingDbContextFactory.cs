using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UOzturk.Listing.Configuration;
using UOzturk.Listing.Web;

namespace UOzturk.Listing.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ListingDbContextFactory : IDesignTimeDbContextFactory<ListingDbContext>
    {
        public ListingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ListingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ListingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ListingConsts.ConnectionStringName));

            return new ListingDbContext(builder.Options);
        }
    }
}
