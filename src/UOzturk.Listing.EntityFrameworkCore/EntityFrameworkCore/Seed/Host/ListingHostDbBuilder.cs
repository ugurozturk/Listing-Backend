using UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts;

namespace UOzturk.Listing.EntityFrameworkCore.Seed.Host
{
    public class ListingHostDbBuilder
    {
        private readonly ListingDbContext _context;

        public ListingHostDbBuilder(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new ListTypeCreator(_context).Create();
            new UserCreatedListCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
