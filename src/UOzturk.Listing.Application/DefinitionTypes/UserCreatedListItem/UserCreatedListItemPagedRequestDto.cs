using Abp.Application.Services.Dto;

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