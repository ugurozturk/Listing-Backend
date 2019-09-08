﻿using Abp.Application.Services;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using UOzturk.Listing.Facade.IFacade;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedList
{
    public class SystemCreatedListAppService : AsyncCrudAppService<SystemCreatedListEntity, SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>, ISystemCreatedListAppService
    {
        private readonly ISystemCreatedListFacade _systemCreatedListFacade;

        public SystemCreatedListAppService(
            IRepository<SystemCreatedListEntity, int> repository,
            ISystemCreatedListFacade systemCreatedListFacade
            ) : base(repository)
        {
            _systemCreatedListFacade = systemCreatedListFacade;
        }

        public List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            return _systemCreatedListFacade.GetAllWithItems(input);
        }
    }
}