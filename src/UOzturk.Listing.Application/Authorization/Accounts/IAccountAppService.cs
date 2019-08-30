﻿using System.Threading.Tasks;
using Abp.Application.Services;
using UOzturk.Listing.Authorization.Accounts.Dto;

namespace UOzturk.Listing.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
