using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    [AutoMapFrom(typeof(UserCreatedListEntity))]
    public class UserCreatedListDto : EntityDto
    {
        public string Name { get; set; }

        public int ListTypeId { get; set; }

        public long ListOwnerUserId { get; set; }

        public User User { get; set; }

        public ListTypeEntity ListType { get; set; }
    }
}
