using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Editions;
using Abp.Application.Features;
using UOzturk.Listing.Editions;

namespace UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts
{
    public class ListTypeCreator
    {
        private readonly ListingDbContext _context;

        public ListTypeCreator(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateListType();
        }

        private void CreateListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.DefaultUserCreatedListName };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }
    }
}
