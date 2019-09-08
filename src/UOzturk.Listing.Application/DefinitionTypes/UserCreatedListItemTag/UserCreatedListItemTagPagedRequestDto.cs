using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public class UserCreatedListItemTagPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public int? UserCreatedListItemId { get; set; }
    }
}
