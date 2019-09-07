using Abp.Domain.Repositories;
using System.Collections.Generic;
using UOzturk.Listing.DefinitionTypes.SystemCreatedList;
using UOzturk.Listing.List;

namespace UOzturk.Listing.IRepositories
{
    public interface ISystemCreatedListRepository : IRepository<SystemCreatedListEntity>
    {
        List<SystemCreatedListEntity> GetAllWithItems(SystemCreatedListPagedRequestDto input);
    }
}
