using Abp.Application.Services;

namespace UOzturk.Listing.ListType
{
    public interface IListTypeAppService : IAsyncCrudAppService<ListTypeDto, int, ListTypePagedRequestDto, CreateListTypeDto, UpdateListTypeDto>
    {
    }
}