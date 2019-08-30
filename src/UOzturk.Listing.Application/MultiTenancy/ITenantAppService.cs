using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UOzturk.Listing.MultiTenancy.Dto;

namespace UOzturk.Listing.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

