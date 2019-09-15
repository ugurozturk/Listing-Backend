using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType;
using UOzturk.Listing.UserCreatedListItem;
using UOzturk.Listing.Users.Dto;

namespace UOzturk.Listing.UserCreatedList
{
    [AutoMapFrom(typeof(UserCreatedListEntity))]
    public class UserCreatedListDto : EntityDto
    {
        public string Name { get; set; }
        
        public UserDto User { get; set; }

        public ListTypeDto ListType { get; set; }

        public PagedResultDto<UserCreatedListItemDto> UserCreatedListItemCollection { get; set; }
    }
}