using Abp.Application.Services;
using UOzturk.Listing.ListType.Dto;

namespace UOzturk.Listing.ListType
{
    public interface IListTypeAppService : IAsyncCrudAppService<ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>
    {
    }
}