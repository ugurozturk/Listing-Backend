using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOzturk.Listing.Facade.IFacade;
using UOzturk.Listing.IRepositories;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType;
using UOzturk.Listing.SystemCreatedList;
using UOzturk.Listing.SystemCreatedListItem;

namespace UOzturk.Listing.Facade
{
    public class SystemCreatedListFacade : ISystemCreatedListFacade
    {
        private readonly ISystemCreatedListRepository _systemCreatedListRepository;
        private readonly IRepository<SystemCreatedListItemEntity, int> _systemCreatedListItemRepository;

        public SystemCreatedListFacade(ISystemCreatedListRepository systemCreatedListRepository,
            IRepository<SystemCreatedListItemEntity, int> systemCreatedListItemRepository)
        {
            _systemCreatedListRepository = systemCreatedListRepository;
            _systemCreatedListItemRepository = systemCreatedListItemRepository;
        }

        public async Task<PagedResultDto<SystemCreatedListPagedItemsDto>> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            var res = await _systemCreatedListRepository.GetAllWithItems(input.ListTypeId)
                .OrderBy(x => x.Id)
                .Select(x => new SystemCreatedListPagedItemsDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ListType = new ListTypeDto
                    {
                        Id = x.ListType.Id,
                        Name = x.ListType.Name
                    },
                    SystemCreatedListItemCollection = new PagedResultDto<SystemCreatedListItemDto>(x.SystemCreatedListItemCollection.Count,
                        x.SystemCreatedListItemCollection
                        .OrderBy(y => y.Id)
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                        .Select(y => new SystemCreatedListItemDto()
                        {
                            Id = y.Id,
                            Name = y.Name,
                            Link = y.Link,
                            IsPc = y.IsPc,
                            IsPs = y.IsPs,
                            IsVideo = y.IsVideo,
                            IsXBox = y.IsXBox,
                            ReleaseDate = y.ReleaseDate
                        }).ToList())
                }).ToListAsync();

            return new PagedResultDto<SystemCreatedListPagedItemsDto>(res.Count(), res);
        }

        public int GetListsCount()
        {
            return _systemCreatedListRepository.Count();
        }

        public int GetItemsCount()
        {
            return _systemCreatedListItemRepository.Count();
        }
    }
}