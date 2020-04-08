using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts
{
    public class UserCreatedListItemCreator
    {
        private readonly ListingDbContext _context;

        public UserCreatedListItemCreator(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserCreatedListItem();
            CreateUserCreatedListItem2();
        }

        private void CreateUserCreatedListItem()
        {
            var defaultEdition = _context.UserCreatedListItem.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultUserCreatedListItemName);
            if (defaultEdition == null)
            {
                defaultEdition = new List.UserCreatedListItemEntity {
                    Name = ListingConsts.DefaultUserCreatedListItemName,
                    Score = 7,
                    UserCreatedListId = _context.UserCreatedList.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultUserCreatedListName).Id,
                    SystemCreatedListItemId = _context.SystemCreatedListItem.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultSystemCreatedListItemName).Id
                };

                _context.UserCreatedListItem.Add(defaultEdition);
            }
        }


        private void CreateUserCreatedListItem2()
        {
            var defaultEdition = _context.UserCreatedListItem.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultUserCreatedListItemName2);
            if (defaultEdition == null)
            {
                defaultEdition = new List.UserCreatedListItemEntity {
                    Name = ListingConsts.DefaultUserCreatedListItemName2,
                    Score = 7,
                    UserCreatedListId = _context.UserCreatedList.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultUserCreatedListName).Id,
                    SystemCreatedListItemId = _context.SystemCreatedListItem.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultSystemCreatedListItemName).Id
                };

                _context.UserCreatedListItem.Add(defaultEdition);
            }
        }
    }
}
