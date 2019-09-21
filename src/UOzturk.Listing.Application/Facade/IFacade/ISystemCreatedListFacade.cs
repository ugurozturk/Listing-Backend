using Abp.Dependency;
using System.Collections.Generic;
using System.Threading.Tasks;
using UOzturk.Listing.SystemCreatedList;

namespace UOzturk.Listing.Facade.IFacade
{
    public interface ISystemCreatedListFacade : IApplicationFacade
    {
        Task<List<SystemCreatedListPagedItemsDto>> GetAllWithItems(SystemCreatedListPagedRequestDto input);
        
        int GetListsCount();

        int GetItemsCount();
    }
}