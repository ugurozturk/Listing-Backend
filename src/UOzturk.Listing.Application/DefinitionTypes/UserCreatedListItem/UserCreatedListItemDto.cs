using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItem
{
    [AutoMapFrom(typeof(UserCreatedListItemEntity))]
    public class UserCreatedListItemDto : EntityDto
    {
        public string Name { get; set; }

        public short Score { get; set; }

        public int? UserCreatedListId { get; set; }

        public int SystemCreatedListItemId { get; set; }

        public UserCreatedListEntity UserCreatedList { get; set; }

        public SystemCreatedListItemEntity SystemCreatedListItem { get; set; }
    }
}