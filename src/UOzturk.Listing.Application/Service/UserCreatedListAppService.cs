using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList
{
    public class UserCreatedListAppService : AsyncCrudAppService<UserCreatedListEntity, UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>, IUserCreatedListAppService
    {
        private readonly IAbpSession _session;
        public UserCreatedListAppService(
            IRepository<UserCreatedListEntity, int> repository,
            IAbpSession session) : base(repository)
        {
            _session = session;
        }

        [AbpAuthorize]
        public override async Task<UserCreatedListDto> CreateAsync(CreateUserCreatedListDto input)
        {
            input.ListOwnerUserId = _session.UserId ?? 1;
            return await base.CreateAsync(input);
        }
    }
}