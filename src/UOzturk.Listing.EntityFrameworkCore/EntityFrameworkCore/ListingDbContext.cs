using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using UOzturk.Listing.Authorization.Roles;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.MultiTenancy;

namespace UOzturk.Listing.EntityFrameworkCore
{
    public class ListingDbContext : AbpZeroDbContext<Tenant, Role, User, ListingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ListingDbContext(DbContextOptions<ListingDbContext> options)
            : base(options)
        {
        }
    }
}
