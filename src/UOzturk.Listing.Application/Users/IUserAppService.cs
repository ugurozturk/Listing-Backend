using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UOzturk.Listing.Roles.Dto;
using UOzturk.Listing.Users.Dto;

namespace UOzturk.Listing.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
