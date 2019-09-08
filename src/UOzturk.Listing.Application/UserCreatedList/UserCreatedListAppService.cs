using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.List;
using UOzturk.Listing.UserCreatedList.Dto;

namespace UOzturk.Listing.UserCreatedList
{
    [AbpAuthorize(PermissionNames.Pages_Users)] //TODO:Ugur this might be wrong, check if user can access this method.
    public class UserCreatedListAppService : AsyncCrudAppService<UserCreatedListEntity, UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>, IUserCreatedListAppService
    {
        public UserCreatedListAppService(
            IRepository<UserCreatedListEntity, int> repository) : base(repository)
        {
        }
    }
}