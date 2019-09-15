using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;
using UOzturk.Listing.List;
using UOzturk.Listing.SystemCreatedListItem;
using UOzturk.Listing.UserCreatedList;
using UOzturk.Listing.UserCreatedListItemTag;

namespace UOzturk.Listing.UserCreatedListItem
{
    [AutoMapFrom(typeof(UserCreatedListItemEntity))]
    public class UserCreatedListItemDto : EntityDto
    {
        public string Name { get; set; }

        public short Score { get; set; }

        public UserCreatedListDto UserCreatedList { get; set; }

        public SystemCreatedListItemDto SystemCreatedListItem { get; set; }

        public List<UserCreatedListItemTagDto> UserCreatedListItemTagCollection { get;set;}
    }
}