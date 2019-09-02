﻿using Abp.Application.Services;
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
        public UserCreatedListAppService(
            IRepository<UserCreatedListEntity, int> repository,
            IRepository<UserCreatedListItemEntity, int> userCreatedListItemEntity) : base(repository)
        {
            _userCreatedListItemEntity = userCreatedListItemEntity;
        }

        #region User Created List Item
        public IQueryable<UserCreatedListItemEntity> QueryableUserCreatedListItem(UserCreatedListItemPagedRequestDto input)
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
            var newCreatedEntity = await _userCreatedListItemEntity.InsertAsync(createUserCreatedListItemEntity);

            return ObjectMapper.Map<UserCreatedListItemDto>(newCreatedEntity);
        }

        #endregion User Created List Item
    }
}