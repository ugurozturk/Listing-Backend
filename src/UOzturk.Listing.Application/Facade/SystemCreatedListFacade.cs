using System.Collections.Generic;
using System.Linq;
using UOzturk.Listing.IRepositories;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.SystemCreatedList.Dto;
using UOzturk.Listing.SystemCreatedListItem;

namespace UOzturk.Listing.Facade.IFacade
{
    public class SystemCreatedListFacade
    {
        private readonly ISystemCreatedListRepository _systemCreatedListRepository;

        public SystemCreatedListFacade(ISystemCreatedListRepository systemCreatedListRepository)
        {
            _systemCreatedListRepository = systemCreatedListRepository;
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
                    SystemCreatedListItemCollection = x.SystemCreatedListItemCollection.Select(y => new SystemCreatedListItemDto()
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Link = y.Link,
                        IsPc = y.IsPc,
                        IsPs = y.IsPs,
                        IsVideo = y.IsVideo,
                        IsXBox = y.IsXBox,
                        ReleaseDate = y.ReleaseDate
                    }).ToList()
                }).Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

            return test;
        }
    }
}