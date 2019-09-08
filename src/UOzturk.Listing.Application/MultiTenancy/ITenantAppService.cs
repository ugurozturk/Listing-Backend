using Abp.Application.Services;
using UOzturk.Listing.MultiTenancy.Dto;

namespace UOzturk.Listing.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}