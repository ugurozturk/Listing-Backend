using System.Collections.Generic;
using UOzturk.Listing.SystemCreatedList.Dto;

namespace UOzturk.Listing.Facade.IFacade
{
    public interface ISystemCreatedListFacade
    {
        List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input);
    }
}