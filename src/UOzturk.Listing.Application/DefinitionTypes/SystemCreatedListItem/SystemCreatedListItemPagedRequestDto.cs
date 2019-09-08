using Abp.Application.Services.Dto;
using System;

namespace UOzturk.Listing.SystemCreatedListItem
{
    public class SystemCreatedListItemPagedRequestDto : PagedResultRequestDto
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public DateTime? ReleaseDateBegin { get; set; }
        public DateTime? ReleaseDateEnd { get; set; }

        public bool? IsPc { get; set; }

        public bool? IsXBox { get; set; }

        public bool? IsPs { get; set; }

        public bool? IsVideo { get; set; }

        public int? SystemCreatedListId { get; set; }
    }
}