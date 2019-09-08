using Abp.Application.Services;
using Abp.Domain.Repositories;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItem
{
    public class UserCreatedListItemAppService : AsyncCrudAppService<UserCreatedListItemEntity, UserCreatedListItemDto, int, UserCreatedListItemPagedRequestDto, CreateUserCreatedListItemDto, UserCreatedListItemDto>, IUserCreatedListItemAppService
    {
        public UserCreatedListItemAppService(
            IRepository<UserCreatedListItemEntity, int> repository
            ) : base(repository)
        {
        }
    }
}