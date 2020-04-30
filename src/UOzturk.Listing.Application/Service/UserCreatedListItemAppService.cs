using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using AutoMapper;
using UOzturk.Listing.List;
using UOzturk.Listing.UserCreatedListItemTag;

namespace UOzturk.Listing.UserCreatedListItem
{
    public class UserCreatedListItemAppService : AsyncCrudAppService<UserCreatedListItemEntity, UserCreatedListItemDto, int, UserCreatedListItemPagedRequestDto, CreateUserCreatedListItemDto, UserCreatedListItemDto>, IUserCreatedListItemAppService
    {
        private IRepository<UserCreatedListItemTagEntity, int> _userCreatedListItemTagRepository;

        public UserCreatedListItemAppService(
            IRepository<UserCreatedListItemEntity, int> repository,
            IRepository<UserCreatedListItemTagEntity, int> userCreatedListItemTagRepository
            ) : base(repository)
        {
            _userCreatedListItemTagRepository = userCreatedListItemTagRepository;
        }

        public async Task<UserCreatedListItemDto> CreateWithTags(CreateUserCreatedListItemWithTagsDto input)
        {
            UserCreatedListItemDto userCreatedListItemCreateRes = await base.CreateAsync(input);
            userCreatedListItemCreateRes.UserCreatedListItemTagCollection = new List<UserCreatedListItemTagDto>();

            foreach (string tag in input.UserCreatedListItemTags)
            {
                var createTagDto = new CreateUserCreatedListItemTagDto
                {
                    Name = tag,
                    UserCreatedListItemId = userCreatedListItemCreateRes.Id
                };
                UserCreatedListItemTagEntity createTag = ObjectMapper.Map<UserCreatedListItemTagEntity>(createTagDto);
                UserCreatedListItemTagEntity userCreatedListItemTagCreateRes = await _userCreatedListItemTagRepository.InsertAsync(createTag);
                UserCreatedListItemTagDto createTagResDto = ObjectMapper.Map<UserCreatedListItemTagDto>(userCreatedListItemTagCreateRes);
                userCreatedListItemCreateRes.UserCreatedListItemTagCollection.Add(createTagResDto);
            }
            return userCreatedListItemCreateRes;
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