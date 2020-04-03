using System.Linq;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
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

        protected override IQueryable<UserCreatedListItemTagEntity> CreateFilteredQuery(UserCreatedListItemTagPagedRequestDto input){
            return base.CreateFilteredQuery(input)
                .WhereIf(input.Name != default, f => f.Name.Contains(input.Name))
                .WhereIf(input.UserCreatedListItemId != default, f => f.UserCreatedListItemId == input.UserCreatedListItemId);
        }
    }
}