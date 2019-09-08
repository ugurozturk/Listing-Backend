using Abp.Application.Services.Dto;

namespace UOzturk.Listing.SystemCreatedList
{
    public class SystemCreatedListPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public int? ListTypeId { get; set; }
    }
}