using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.ListType.Dto
{
    public class CreateListTypeDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}