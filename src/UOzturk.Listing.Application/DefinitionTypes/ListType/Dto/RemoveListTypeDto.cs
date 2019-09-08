using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.ListType
{
    public class RemoveListTypeDto
    {
        [Required]
        public int ListTypeId { get; set; }
    }
}