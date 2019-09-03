using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.UserCreatedList.Dto;

namespace UOzturk.Listing.UserCreatedList
{
    [AbpAuthorize(PermissionNames.Pages_Users)] //TODO:Ugur this might be wrong, check if user can access this method.
    public class UserCreatedListAppService : AsyncCrudAppService<UserCreatedListEntity, UserCreatedListDto, int, UserCreatedListPagedRequestDto, CreateUserCreatedListDto, UserCreatedListDto>, IUserCreatedListAppService
    {
        private readonly IRepository<UserCreatedListItemEntity, int> _userCreatedListItemEntity;
        private readonly IRepository<UserCreatedListItemTagEntity, int> _userCreatedListItemTagEntity;
        public UserCreatedListAppService(
            IRepository<UserCreatedListEntity, int> repository,
            IRepository<UserCreatedListItemEntity, int> userCreatedListItemEntity,
            IRepository<UserCreatedListItemTagEntity, int> userCreatedListItemTagEntity) : base(repository)
        {
            _userCreatedListItemEntity = userCreatedListItemEntity;
            _userCreatedListItemTagEntity = userCreatedListItemTagEntity;
        }

        #region User Created List Item
        protected IQueryable<UserCreatedListItemEntity> QueryableUserCreatedListItem(UserCreatedListItemPagedRequestDto input)
        {
            return _userCreatedListItemEntity.GetAll()
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), x=>x.Name.Contains(input.Name))
                .WhereIf(input.Score.HasValue, x=>x.Score == input.Score)
                .WhereIf(input.UserCreatedListId.HasValue, x=>x.UserCreatedListId == input.UserCreatedListId)
                .WhereIf(input.SystemCreatedListItemId.HasValue, x=>x.SystemCreatedListItemId == input.SystemCreatedListItemId);
        }

        public async Task<UserCreatedListItemDto> GetUserCreatedListItem(UserCreatedListItemPagedRequestDto input)
        {
            CheckGetPermission();

            var userCreatedListItemEntity = await QueryableUserCreatedListItem(input).FirstOrDefaultAsync();
            return ObjectMapper.Map<UserCreatedListItemDto>(userCreatedListItemEntity);
        }

        public async Task<List<UserCreatedListItemDto>> GetUserCreatedListItemList(UserCreatedListItemPagedRequestDto input)
        {
            CheckGetPermission();

            var userCreatedListItemEntity = await QueryableUserCreatedListItem(input).ToListAsync();
            return ObjectMapper.Map<List<UserCreatedListItemDto>>(userCreatedListItemEntity);
        }

        public async Task<UserCreatedListItemDto> CreateUserCreatedListItem(CreateUserCreatedListItemDto createUserCreatedListItemDto)
        {
            CheckCreatePermission();

            var createUserCreatedListItemEntity = ObjectMapper.Map<UserCreatedListItemEntity>(createUserCreatedListItemDto);
            try
            {
            var newCreatedEntity = await _userCreatedListItemEntity.InsertAsync(createUserCreatedListItemEntity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<UserCreatedListItemDto>(newCreatedEntity);

            }
            catch(Exception ex)
            {
                return null;
            }
        }

        #endregion User Created List Item

        #region User Created List Item Tag
        protected IQueryable<UserCreatedListItemTagEntity> QueryableUserCreatedListItemTag(UserCreatedListItemTagPagedRequestDto input)
        {
            return _userCreatedListItemTagEntity.GetAll()
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
                .WhereIf(input.UserCreatedListItemId.HasValue, x => x.UserCreatedListItemId == input.UserCreatedListItemId);
        }

        public async Task<UserCreatedListItemTagDto> GetUserCreatedListItemTag(UserCreatedListItemTagPagedRequestDto input)
        {
            CheckGetPermission();

            var userCreatedListItemTagEntity = await QueryableUserCreatedListItemTag(input).FirstOrDefaultAsync();
            return ObjectMapper.Map<UserCreatedListItemTagDto>(userCreatedListItemTagEntity);
        }

        public async Task<List<UserCreatedListItemTagDto>> GetUserCreatedListItemTagList(UserCreatedListItemTagPagedRequestDto input)
        {
            CheckGetPermission();

            var userCreatedListItemTagEntity = await QueryableUserCreatedListItemTag(input).ToListAsync();
            return ObjectMapper.Map<List<UserCreatedListItemTagDto>>(userCreatedListItemTagEntity);
        }

        public async Task<UserCreatedListItemTagDto> CreateUserCreatedListItemTag(CreateUserCreatedListItemTagDto createUserCreatedListItemDto)
        {
            CheckCreatePermission();

            var createUserCreatedListItemTagEntity = ObjectMapper.Map<UserCreatedListItemTagEntity>(createUserCreatedListItemDto);
            var newCreatedEntity = await _userCreatedListItemTagEntity.InsertAsync(createUserCreatedListItemTagEntity);

            return ObjectMapper.Map<UserCreatedListItemTagDto>(newCreatedEntity);
        }

        #endregion User Created List Item Tag
    }
}