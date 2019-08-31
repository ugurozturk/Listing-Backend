﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.List;

namespace UOzturk.Listing.ListType.Dto
{
    [AutoMapFrom(typeof(ListTypeEntity))]
    public class ListTypeDto : EntityDto
    {
        public string Name { get; set; }
    }
}