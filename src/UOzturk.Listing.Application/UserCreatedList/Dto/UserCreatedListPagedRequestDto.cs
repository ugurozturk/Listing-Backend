using Abp.Application.Services.Dto;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    public class UserCreatedListPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public int ListTypeId { get; set; }

        public long ListOwnerUserId { get; set; }
    }
}