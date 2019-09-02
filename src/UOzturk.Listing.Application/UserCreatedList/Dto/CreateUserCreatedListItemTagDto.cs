using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    [AutoMapTo(typeof(UserCreatedListItemTagEntity))]
    public class CreateUserCreatedListItemTagDto
    {
        public string Name { get; set; }

        public int UserCreatedListItemId { get; set; }
    }
}
