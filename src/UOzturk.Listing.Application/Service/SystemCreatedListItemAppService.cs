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

namespace UOzturk.Listing.SystemCreatedListItem
{
    public class SystemCreatedListItemAppService : AsyncCrudAppService<SystemCreatedListItemEntity, SystemCreatedListItemDto, int, SystemCreatedListItemPagedRequestDto, CreateSystemCreatedListItemDto, SystemCreatedListItemDto>, ISystemCreatedListItemAppService
    {
        public SystemCreatedListItemAppService(
            IRepository<SystemCreatedListItemEntity, int> repository
            ) : base(repository)
        {
        }
    }
}