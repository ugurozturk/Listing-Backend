using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using UOzturk.Listing.Authorization.Roles;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.MultiTenancy;
using UOzturk.Listing.List;

namespace UOzturk.Listing.EntityFrameworkCore
{
    public class ListingDbContext : AbpZeroDbContext<Tenant, Role, User, ListingDbContext>
    {
        public DbSet<ListType> ListType { get; set; }

        public DbSet<SystemCreatedList> SystemCreatedList { get; set; }

        public DbSet<SystemCreatedListItem> SystemCreatedListItem { get; set; }

        public DbSet<UserCreatedListItemTag> UserCreatedListItemTag { get; set; }

        public DbSet<UserCreatedList> UserCreatedList { get; set; }

        public DbSet<UserCreatedListItem> UserCreatedListItem { get; set; }

        public ListingDbContext(DbContextOptions<ListingDbContext> options)
            : base(options)
        {
        }
    }
}
