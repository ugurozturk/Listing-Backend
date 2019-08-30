using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.MultiTenancy;

namespace UOzturk.Listing.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
