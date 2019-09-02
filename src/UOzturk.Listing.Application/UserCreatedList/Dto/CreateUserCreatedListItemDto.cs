﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.Authorization.Users;
using UOzturk.Listing.List;

namespace UOzturk.Listing.UserCreatedList.Dto
{
    [AutoMapTo(typeof(UserCreatedListItemEntity))]
    public class CreateUserCreatedListItemDto
    {
        public string Name { get; set; }

        public short Score { get; set; }

        public int? UserCreatedListId { get; set; }

        public int SystemCreatedListItemId { get; set; }
    }
}
