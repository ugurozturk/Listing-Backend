using Abp.Application.Services;

namespace UOzturk.Listing.UserCreatedList
{
    public interface IUserCreatedListAppService : IAsyncCrudAppService<UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>
    {
    }
}