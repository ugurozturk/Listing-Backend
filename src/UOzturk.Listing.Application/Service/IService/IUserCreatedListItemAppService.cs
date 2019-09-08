using Abp.Application.Services;

namespace UOzturk.Listing.UserCreatedListItem
{
    public interface ISystemCreatedListItemAppService : IAsyncCrudAppService<UserCreatedListItemDto, int, UserCreatedListItemPagedRequestDto, CreateUserCreatedListItemDto, UserCreatedListItemDto>
    {
    }
}