using Abp.Application.Services.Dto;

namespace UOzturk.Listing.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}