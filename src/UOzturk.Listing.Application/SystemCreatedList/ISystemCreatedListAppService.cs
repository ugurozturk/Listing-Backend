using Abp.Application.Services;
using System.Collections.Generic;
using UOzturk.Listing.DefinitionTypes.SystemCreatedList;
using UOzturk.Listing.List;
using UOzturk.Listing.SystemCreatedList.Dto;

namespace UOzturk.Listing.SystemCreatedList
{
    public interface ISystemCreatedListAppService : IAsyncCrudAppService<SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>
    {
        List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input);
    }
}