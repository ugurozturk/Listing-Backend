using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.List;
using UOzturk.Listing.UserCreatedListItem;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    [AutoMapFrom(typeof(UserCreatedListItemTagEntity))]
    public class UserCreatedListItemTagDto : EntityDto
    {
        public string Name { get; set; }
    }
}