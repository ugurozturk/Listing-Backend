using Abp.Application.Services.Dto;

namespace UOzturk.Listing.ListType
{
    public class ListTypePagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }
    }
}