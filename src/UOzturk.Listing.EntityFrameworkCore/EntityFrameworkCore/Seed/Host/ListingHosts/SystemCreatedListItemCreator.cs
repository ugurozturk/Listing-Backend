using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts
{
    public class SystemCreatedListItemCreator
    {
        private readonly ListingDbContext _context;

        public SystemCreatedListItemCreator(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateSystemCreatedList();
        }

        private void CreateSystemCreatedList()
        {
            var defaultEdition = _context.SystemCreatedList.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultSystemCreatedListName);
            if (defaultEdition == null)
            {
                defaultEdition = new List.SystemCreatedListEntity
                {
                    Name = ListingConsts.DefaultSystemCreatedListName,
                    ListTypeId = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultListType).Id
                };

                _context.SystemCreatedList.Add(defaultEdition);
                _context.SaveChanges();
            }
        }
    }
}
