using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    [AutoMapFrom(typeof(UserCreatedListItemTagEntity))]
    public class UserCreatedListItemTagDto : EntityDto
    {
        public string Name { get; set; }

        public int UserCreatedListItemId { get; set; }

        public UserCreatedListItemEntity UserCreatedListItem { get; set; }
    }
}
