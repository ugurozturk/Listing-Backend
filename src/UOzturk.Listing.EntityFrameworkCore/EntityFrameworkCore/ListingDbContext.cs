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
        public DbSet<ListTypeEntity> ListType { get; set; }

        public DbSet<SystemCreatedListEntity> SystemCreatedList { get; set; }

        public DbSet<SystemCreatedListItemEntity> SystemCreatedListItem { get; set; }

        public DbSet<UserCreatedListItemTagEntity> UserCreatedListItemTag { get; set; }

        public DbSet<UserCreatedListEntity> UserCreatedList { get; set; }

        public DbSet<UserCreatedListItemEntity> UserCreatedListItem { get; set; }

        public ListingDbContext(DbContextOptions<ListingDbContext> options)
            : base(options)
        {
        }
    }
}
