using Abp.Application.Services;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public interface IUserCreatedListItemTagAppService : IAsyncCrudAppService<UserCreatedListItemTagDto, int, UserCreatedListItemTagPagedRequestDto, CreateUserCreatedListItemTagDto, UserCreatedListItemTagDto>
    {
    }
}