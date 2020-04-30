using Abp.Application.Services;
using System.Threading.Tasks;

namespace UOzturk.Listing.UserCreatedListItem
{
    public interface IUserCreatedListItemAppService : IAsyncCrudAppService<UserCreatedListItemDto, int, UserCreatedListItemPagedRequestDto, CreateUserCreatedListItemDto, UserCreatedListItemDto>
    {
        Task<UserCreatedListItemDto> CreateWithTags(CreateUserCreatedListItemWithTagsDto input);
    }
}