using Abp.Application.Services;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public interface ISystemCreatedListItemAppService : IAsyncCrudAppService<SystemCreatedListItemDto, int, SystemCreatedListItemPagedRequestDto, CreateSystemCreatedListItemDto, SystemCreatedListItemDto>
    {
    }
}