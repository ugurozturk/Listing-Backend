using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore
{
    public static class ListingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ListingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ListingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
