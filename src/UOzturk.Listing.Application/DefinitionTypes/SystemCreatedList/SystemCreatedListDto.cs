﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType;
using UOzturk.Listing.SystemCreatedListItem;

namespace UOzturk.Listing.SystemCreatedList
{
    [AutoMapFrom(typeof(SystemCreatedListEntity))]
    public class SystemCreatedListDto : EntityDto
    {
        public string Name { get; set; }

        public ListTypeDto ListType { get; set; }

        //public List<SystemCreatedListItemDto> SystemCreatedListItemCollection { get; set; }
    }
}