using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.Authorization.Roles;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.Editions;
using UOzturk.Listing.MultiTenancy.Dto;
using Microsoft.AspNetCore.Identity;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType
{
    [AbpAuthorize(PermissionNames.Pages_Users)] //TODO:Ugur this might be wrong, check if user can access this method.
    public class ListTypeAppService : AsyncCrudAppService<List.ListType, ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>, IListTypeAppService
    {
        public ListTypeAppService(IRepository<List.ListType, int> repository) : base(repository)
        {
        }
    }
}

