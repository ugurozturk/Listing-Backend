using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Roles;
using AutoMapper;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UOzturk.Listing.Authorization.Roles;
using UOzturk.Listing.List;
using UOzturk.Listing.SystemCreatedListItem;

namespace UOzturk.Listing.MapProfile
{
    public class SystemCreatedListMapProfile : Profile
    {
        public SystemCreatedListMapProfile()
        {
            //CreateMap<IEnumerable<SystemCreatedListItemDto>, PagedResultDto<SystemCreatedListItemDto>>().ReverseMap();
        }
    }
}