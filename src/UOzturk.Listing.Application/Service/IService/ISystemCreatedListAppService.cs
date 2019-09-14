using Abp.Application.Services;
using System.Collections.Generic;

namespace UOzturk.Listing.SystemCreatedList
{
    public interface ISystemCreatedListAppService : IAsyncCrudAppService<SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>
    {
        List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input);

        int GetListsCount();

        int GetItemsCount();
    }
}