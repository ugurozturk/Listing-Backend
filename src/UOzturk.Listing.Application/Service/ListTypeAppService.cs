using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType
{
    [AbpAuthorize(PermissionNames.Pages_Users)] //TODO:Ugur this might be wrong, check if user can access this method.
    public class ListTypeAppService : AsyncCrudAppService<ListTypeEntity, ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>, IListTypeAppService
    {
        public ListTypeAppService(IRepository<ListTypeEntity, int> repository) : base(repository)
        {
        }

        public string YoutubeVideoTestServisi() 
        {
            return "Youtube Testi Data Döndü";
        }
    }
}
