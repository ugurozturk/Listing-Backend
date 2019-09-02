using System.Collections.Generic;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedList.Dto
{
    public class SystemCreatedListExtDto
    {
        public string Name { get; set; }

        public int ListTypeId { get; set; }

        public ListTypeEntity ListType { get; set; }

        public IList<SystemCreatedListItemEntity> SystemCreatedListItemCollection { get; set; }
    }
}