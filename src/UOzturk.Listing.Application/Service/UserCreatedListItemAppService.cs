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
using UOzturk.Listing.Facade.IFacade;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.SystemCreatedList.Dto;

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