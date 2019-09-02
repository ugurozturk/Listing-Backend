using Abp.Application.Services;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.UserCreatedList.Dto;

namespace UOzturk.Listing.UserCreatedList
{
    public interface IUserCreatedListAppService : IAsyncCrudAppService<UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>
    {
    }
}