using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.ListType.Dto
{
    public class UpdateListTypeDto : EntityDto
    {
        [Required]
        public int ListTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}