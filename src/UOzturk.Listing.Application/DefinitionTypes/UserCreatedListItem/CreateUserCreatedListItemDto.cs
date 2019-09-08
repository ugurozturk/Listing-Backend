using Abp.AutoMapper;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItem
{
    [AutoMapTo(typeof(UserCreatedListItemEntity))]
    public class CreateUserCreatedListItemDto
    {
        public string Name { get; set; }

        public short Score { get; set; }

        public int? UserCreatedListId { get; set; }

        public int SystemCreatedListItemId { get; set; }
    }
}