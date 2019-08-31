using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.ListType.Dto
{
    public class RemoveListTypeDto
    {
        [Required]
        public int ListTypeId { get; set; }
    }
}