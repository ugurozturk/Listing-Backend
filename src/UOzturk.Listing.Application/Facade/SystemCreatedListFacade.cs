using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IObjectMapper _objectMapper;

        public SystemCreatedListFacade(ISystemCreatedListRepository systemCreatedListRepository, 
            IRepository<SystemCreatedListItemEntity, int> systemCreatedListItemRepository,
            IObjectMapper objectMapper)
        {
            _systemCreatedListRepository = systemCreatedListRepository;
            _systemCreatedListItemRepository = systemCreatedListItemRepository;
            _objectMapper = objectMapper;
        }

        public List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            var test = _systemCreatedListRepository.GetAllWithItems(input.ListTypeId)
                .Select(x => new SystemCreatedListDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ListType = new ListTypeDto
                    {
                        Id = x.ListType.Id,
                        Name = x.ListType.Name
                    },
                    SystemCreatedListItemCollection = new PagedResultDto<SystemCreatedListItemDto>(x.SystemCreatedListItemCollection.Count, x.SystemCreatedListItemCollection.Select(y => new SystemCreatedListItemDto()
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Link = y.Link,
                        IsPc = y.IsPc,
                        IsPs = y.IsPs,
                        IsVideo = y.IsVideo,
                        IsXBox = y.IsXBox,
                        ReleaseDate = y.ReleaseDate
                    }).OrderByDescending(y=>y.Id).Skip(input.SkipCount).Take(input.MaxResultCount).ToList())
                });

            var test2 = test.ToList();

            return test2;
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