using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    public class UserCreatedListPagedRequestDtoDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public int ListTypeId { get; set; }

        public long ListOwnerUserId { get; set; }
    }
}
