using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;

using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
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

        protected override IQueryable<UserCreatedListItemEntity> CreateFilteredQuery(UserCreatedListItemPagedRequestDto input){
            return base.CreateFilteredQuery(input)
                .WhereIf(input.Name != default, f => f.Name.Contains(input.Name))
                .WhereIf(input.Score != default, f => f.Score == input.Score)
                .WhereIf(input.UserCreatedListId != default, f => f.UserCreatedListId == input.UserCreatedListId)
                .WhereIf(input.SystemCreatedListItemId != default, f => f.SystemCreatedListItemId == input.SystemCreatedListItemId);
        }
    }
}