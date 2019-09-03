using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using UOzturk.Listing.List;

namespace UOzturk.Listing.IRepositories
{
    public interface ISystemCreatedListRepository : IRepository<SystemCreatedListEntity>
    {
        List<SystemCreatedListEntity> GetAllWithItems(int? ListTypeId);
    }
}
