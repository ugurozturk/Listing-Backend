using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.ListType.Dto
{
    [AutoMapTo(typeof(List.ListType))]
    public class CreateListTypeDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}