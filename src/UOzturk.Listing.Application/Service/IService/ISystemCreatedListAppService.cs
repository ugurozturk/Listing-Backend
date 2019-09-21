using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UOzturk.Listing.SystemCreatedList
{
    public interface ISystemCreatedListAppService : IAsyncCrudAppService<SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>
    {
        Task<List<SystemCreatedListPagedItemsDto>> GetAllWithItems(SystemCreatedListPagedRequestDto input);

        int GetListsCount();

        int GetItemsCount();
    }
}