using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedList.Dto
{
    [AutoMapTo(typeof(SystemCreatedListItemEntity))]
    public class CreateSystemCreatedListItemDto : EntityDto
    {
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Link { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsPc { get; set; }

        public bool IsXBox { get; set; }

        public bool IsPs { get; set; }

        public bool IsVideo { get; set; }

        public int SystemCreatedListId { get; set; }
    }
}