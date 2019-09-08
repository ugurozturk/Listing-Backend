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

namespace UOzturk.Listing.UserCreatedListItemTag
{
    public class UserCreatedListItemTagAppService : AsyncCrudAppService<UserCreatedListItemTagEntity, UserCreatedListItemTagDto, int, UserCreatedListItemTagPagedRequestDto, CreateUserCreatedListItemTagDto, UserCreatedListItemTagDto>, IUserCreatedListItemTagAppService
    {
        public UserCreatedListItemTagAppService(
            IRepository<UserCreatedListItemTagEntity, int> repository
            ) : base(repository)
        {
        }
    }
}