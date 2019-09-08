using Abp.Application.Services;

namespace UOzturk.Listing.UserCreatedListItem
{
    public interface IUserCreatedListItemAppService : IAsyncCrudAppService<UserCreatedListItemDto, int, UserCreatedListItemPagedRequestDto, CreateUserCreatedListItemDto, UserCreatedListItemDto>
    {
    }
}