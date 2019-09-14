using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using UOzturk.Listing.List;

namespace UOzturk.Listing.IRepositories
{
    public interface ISystemCreatedListRepository : IRepository<SystemCreatedListEntity>
    {
        IQueryable<SystemCreatedListEntity> GetAllWithItems(int? listTypeId = null);
    }
}
