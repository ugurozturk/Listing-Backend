using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts
{
    public class UserCreatedListCreator
    {
        private readonly ListingDbContext _context;

        public UserCreatedListCreator(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserCreatedList();
        }

        private void CreateUserCreatedList()
        {
            var defaultEdition = _context.UserCreatedList.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultUserCreatedListName);
            if (defaultEdition == null)
            {
                defaultEdition = new List.UserCreatedListEntity { 
                    Name = ListingConsts.DefaultUserCreatedListName,
                    ListTypeId = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultListType).Id,
                    ListOwnerUserId = _context.Users.IgnoreQueryFilters().FirstOrDefault(e => e.UserName == ListingConsts.DefaultUserName).Id
                    };
                _context.UserCreatedList.Add(defaultEdition);
                _context.SaveChanges();
            }
        }
    }
}
