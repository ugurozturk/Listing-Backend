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
    public class UserCreatedListAppService : AsyncCrudAppService<UserCreatedListEntity, UserCreatedListDto, int, UserCreatedListPagedRequestDtoDto, CreateUserCreatedListDto, UserCreatedListDto>, IUserCreatedListAppService
    {
        private readonly IRepository<UserCreatedListEntity, int> _userCreatedListEntity;
        public UserCreatedListAppService(
            IRepository<UserCreatedListEntity, int> repository,
            IRepository<UserCreatedListEntity, int> userCreatedListEntity) : base(repository)
        {
            _userCreatedListEntity = userCreatedListEntity;
        }
    }
}