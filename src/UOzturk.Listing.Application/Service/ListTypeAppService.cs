using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType
{
    [AbpAuthorize(PermissionNames.Pages_Users, PermissionNames.Pages_Lists)]
    public class ListTypeAppService : AsyncCrudAppService<ListTypeEntity, ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>, IListTypeAppService
    {
        public ListTypeAppService(IRepository<ListTypeEntity, int> repository) : base(repository)
        {
        }
    }
}
