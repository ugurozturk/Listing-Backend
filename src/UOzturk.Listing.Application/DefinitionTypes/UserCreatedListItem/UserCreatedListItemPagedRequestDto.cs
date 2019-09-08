using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItem
{
    public class UserCreatedListItemPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public short? Score { get; set; }

        public int? UserCreatedListId { get; set; }

        public int? SystemCreatedListItemId { get; set; }
    }
}
