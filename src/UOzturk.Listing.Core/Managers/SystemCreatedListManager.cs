using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UOzturk.Listing.DefinitionTypes.SystemCreatedList;
using UOzturk.Listing.IManagers;
using UOzturk.Listing.IRepositories;
using UOzturk.Listing.List;

namespace UOzturk.Listing.Managers
{
    public class SystemCreatedListManager : DomainService, ISystemCreatedListManager
    {
        private readonly ISystemCreatedListRepository _systemCreatedListRepository;

        public SystemCreatedListManager(ISystemCreatedListRepository systemCreatedListRepository)
        {
            _systemCreatedListRepository = systemCreatedListRepository;
        }

        public List<SystemCreatedListEntity> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            return _systemCreatedListRepository.GetAllWithItems(input);
        }
    }
}
