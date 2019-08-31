using Abp.Application.Services.Dto;

namespace UOzturk.Listing.ListType.Dto
{
    public class ListTypePagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }
    }
}