using Abp.Application.Services;
using Abp.Domain.Repositories;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedListItem
{
    public class SystemCreatedListItemAppService : AsyncCrudAppService<SystemCreatedListItemEntity, SystemCreatedListItemDto, int, SystemCreatedListItemPagedRequestDto, CreateSystemCreatedListItemDto, SystemCreatedListItemDto>, ISystemCreatedListItemAppService
    {
        public SystemCreatedListItemAppService(
            IRepository<SystemCreatedListItemEntity, int> repository
            ) : base(repository)
        {
        }
    }
}