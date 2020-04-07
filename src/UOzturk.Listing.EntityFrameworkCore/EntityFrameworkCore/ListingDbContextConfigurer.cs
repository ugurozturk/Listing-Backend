using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore
{
    public static class ListingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ListingDbContext> builder, string connectionString)
        {
            builder.UseSqlite(connectionString);
            builder.UseLazyLoadingProxies();
        }

        public static void Configure(DbContextOptionsBuilder<ListingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlite(connection);
            builder.UseLazyLoadingProxies();
        }
    }
}
