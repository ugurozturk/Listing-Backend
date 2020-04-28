using Abp.AutoMapper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedListItem
{
    [AutoMapTo(typeof(UserCreatedListItemEntity))]
    public class CreateUserCreatedListItemDto
    {
        public string Name { get; set; }

        public short Score { get; set; }

        [Required]
        public int? UserCreatedListId { get; set; }
        
        public int? SystemCreatedListItemId { get; set; }
    }

    public class CreateUserCreatedListItemWithTagsDto : CreateUserCreatedListItemDto
    {
        public List<string> Tags { get; set; }
    }
}