using System.Collections.Generic;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType
{
    public class ListTypeExtDto
    {
        public string Name { get; set; }

        public IList<UserCreatedListEntity> UserCreatedList { get; set; }

        public IList<SystemCreatedListEntity> SystemCreatedListCollection { get; set; }
    }
}