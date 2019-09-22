using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<PagedResultDto<SystemCreatedListPagedItemsDto>> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            return await _systemCreatedListFacade.GetAllWithItems(input);
        }

        public int GetListsCount()
        {
            return _systemCreatedListFacade.GetListsCount();
        }

        public int GetItemsCount()
        {
            return _systemCreatedListFacade.GetItemsCount();
        }
    }
}