using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UOzturk.Listing.SystemCreatedList
{
    public interface ISystemCreatedListAppService : IAsyncCrudAppService<SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>
    {
        Task<PagedResultDto<SystemCreatedListPagedItemsDto>> GetAllWithItems(SystemCreatedListPagedRequestDto input);

        int GetListsCount();

        int GetItemsCount();
    }
}