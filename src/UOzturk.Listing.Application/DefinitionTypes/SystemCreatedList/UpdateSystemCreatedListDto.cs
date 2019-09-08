using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedList
{
    [AutoMapTo(typeof(SystemCreatedListEntity))]
    public class UpdateSystemCreatedListDto : EntityDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int ListTypeId { get; set; }
    }
}