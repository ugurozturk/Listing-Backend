using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType
{
    [AutoMapTo(typeof(ListTypeEntity))]
    public class UpdateListTypeDto : EntityDto
    {
        [Required]
        public int ListTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}