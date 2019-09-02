﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    [AutoMapTo(typeof(UserCreatedListEntity))]
    public class CreateUserCreatedListDto
    {
        public string Name { get; set; }

        public int ListTypeId { get; set; }

        public long ListOwnerUserId { get; set; }
    }
}
