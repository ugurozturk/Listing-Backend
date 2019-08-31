﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace UOzturk.Listing.ListType.Dto
{
    [AutoMapFrom(typeof(List.ListType))]
    public class ListTypeDto : EntityDto
    {
        public string Name { get; set; }
    }
}