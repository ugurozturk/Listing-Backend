using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UOzturk.Listing.List;

namespace UOzturk.Listing.IManagers
{
    public interface ISystemCreatedListManager: IDomainService
    {
        List<SystemCreatedListEntity> GetAllWithItems(int? listTypeId);
    }
}
