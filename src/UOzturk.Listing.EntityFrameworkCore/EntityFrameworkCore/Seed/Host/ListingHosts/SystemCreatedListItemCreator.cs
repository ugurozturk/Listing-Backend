using System;
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
            CreateSystemCreatedListItem();
        }

        private void CreateSystemCreatedListItem()
        {
            var defaultEdition = _context.SystemCreatedListItem.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultSystemCreatedListItemName);
            if (defaultEdition == null)
            {
                defaultEdition = new List.SystemCreatedListItemEntity
                {
                    Name = ListingConsts.DefaultSystemCreatedListItemName,
                    Link = string.Empty,
                    ReleaseDate = DateTime.Today,
                    IsPc = false,
                    IsXBox = false,
                    IsPs = false,
                    IsVideo = false,
                    SystemCreatedListId = _context.SystemCreatedList.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultSystemCreatedListName).Id,
                };

                _context.SystemCreatedListItem.Add(defaultEdition);
                _context.SaveChanges();
            }
        }
    }
}
