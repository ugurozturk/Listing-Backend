using Abp.Application.Services.Dto;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public class UserCreatedListItemTagPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public int? UserCreatedListItemId { get; set; }
    }
}