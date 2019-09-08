using Abp.Application.Services;

namespace UOzturk.Listing.SystemCreatedListItem
{
    public interface ISystemCreatedListItemAppService : IAsyncCrudAppService<SystemCreatedListItemDto, int, SystemCreatedListItemPagedRequestDto, CreateSystemCreatedListItemDto, SystemCreatedListItemDto>
    {
    }
}