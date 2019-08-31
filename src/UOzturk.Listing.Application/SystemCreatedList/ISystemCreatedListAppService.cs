using Abp.Application.Services;
using UOzturk.Listing.ListType.Dto;

namespace UOzturk.Listing.ListType
{
    public interface ISystemCreatedListAppService : IAsyncCrudAppService<SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>
    {
    }
}