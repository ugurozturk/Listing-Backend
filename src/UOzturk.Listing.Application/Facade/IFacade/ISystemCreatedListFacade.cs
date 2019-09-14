using Abp.Dependency;
using System.Collections.Generic;
using UOzturk.Listing.SystemCreatedList;

namespace UOzturk.Listing.Facade.IFacade
{
    public interface ISystemCreatedListFacade : IApplicationFacade
    {
        List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input);
        
        int GetListsCount();

        int GetItemsCount();
    }
}