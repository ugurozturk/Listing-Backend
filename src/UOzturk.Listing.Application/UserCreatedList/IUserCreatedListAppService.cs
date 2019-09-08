using Abp.Application.Services;
using UOzturk.Listing.UserCreatedList.Dto;

namespace UOzturk.Listing.UserCreatedList
{
    public interface IUserCreatedListAppService : IAsyncCrudAppService<UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>
    {
    }
}