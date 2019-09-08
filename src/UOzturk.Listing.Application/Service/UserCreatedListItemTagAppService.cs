using Abp.Application.Services;
using Abp.Domain.Repositories;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public class UserCreatedListItemTagAppService : AsyncCrudAppService<UserCreatedListItemTagEntity, UserCreatedListItemTagDto, int, UserCreatedListItemTagPagedRequestDto, CreateUserCreatedListItemTagDto, UserCreatedListItemTagDto>, IUserCreatedListItemTagAppService
    {
        public UserCreatedListItemTagAppService(
            IRepository<UserCreatedListItemTagEntity, int> repository
            ) : base(repository)
        {
        }
    }
}