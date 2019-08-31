using System.Collections.Generic;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType.Dto
{
    public class ListTypeExtDto
    {
        public string Name { get; set; }

        public IList<UserCreatedList> UserCreatedList { get; set; }

        public IList<SystemCreatedList> SystemCreatedListCollection { get; set; }
    }
}