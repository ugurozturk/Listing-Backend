﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using UOzturk.Listing.Roles.Dto;

namespace UOzturk.Listing.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
    }
}