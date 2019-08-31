using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType.Dto
{
    [AutoMapTo(typeof(ListTypeEntity))]
    public class CreateListTypeDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}