using Abp.AutoMapper;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    [AutoMapTo(typeof(UserCreatedListItemTagEntity))]
    public class CreateUserCreatedListItemTagDto
    {
        public string Name { get; set; }

        public int UserCreatedListItemId { get; set; }
    }
}