using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType.Dto;

namespace UOzturk.Listing.ListType
{
    [AbpAuthorize(PermissionNames.Pages_Users)] //TODO:Ugur this might be wrong, check if user can access this method.
    public class SystemCreatedListAppService : AsyncCrudAppService<SystemCreatedListEntity, SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>, ISystemCreatedListAppService
    {
        public SystemCreatedListAppService(IRepository<SystemCreatedListEntity, int> repository) : base(repository)
        {
        }
    }
}