using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType.Dto
{
    [AutoMapFrom(typeof(SystemCreatedListItemEntity))]
    public class SystemCreatedListItemDto : EntityDto
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsPc { get; set; }

        public bool IsXBox { get; set; }

        public bool IsPs { get; set; }

        public bool IsVideo { get; set; }

        //Bunu belki silebilirsin. Debug için koyuyorum.
        public int SystemCreatedListId { get; set; }

        public SystemCreatedListEntity SystemCreatedList { get; set; }
    }
}