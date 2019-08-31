using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UOzturk.Listing.ListType.Dto;

namespace UOzturk.Listing.ListType
{
    public interface IListTypeAppService : IAsyncCrudAppService<ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>
    {
    }
}

