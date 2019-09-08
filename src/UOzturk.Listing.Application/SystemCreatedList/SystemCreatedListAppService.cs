using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.Facade.IFacade;
using UOzturk.Listing.List;
using UOzturk.Listing.ListType.Dto;
using UOzturk.Listing.SystemCreatedList.Dto;

namespace UOzturk.Listing.SystemCreatedList
{
    public class SystemCreatedListAppService : AsyncCrudAppService<SystemCreatedListEntity, SystemCreatedListDto, int, SystemCreatedListPagedRequestDto, CreateSystemCreatedListDto, UpdateSystemCreatedListDto>, ISystemCreatedListAppService
    {
        private readonly ISystemCreatedListFacade _systemCreatedListFacade;
        public SystemCreatedListAppService(
            IRepository<SystemCreatedListEntity, int> repository,
            ISystemCreatedListFacade systemCreatedListFacade
            ) : base(repository)
        {
            _systemCreatedListFacade = systemCreatedListFacade;
        }

        public List<SystemCreatedListDto> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            return _systemCreatedListFacade.GetAllWithItems(input);
        }

        //public IQueryable<SystemCreatedListItemEntity> QueryableSystemCreatedListItem(SystemCreatedListItemPagedRequestDto systemCreatedListItemPagedRequest)
        //{
        //    return _systemCreatedListItemRepository.GetAll()
        //        .WhereIf(!systemCreatedListItemPagedRequest.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(systemCreatedListItemPagedRequest.Name))
        //        .WhereIf(!systemCreatedListItemPagedRequest.Link.IsNullOrWhiteSpace(), x => x.Link.Contains(systemCreatedListItemPagedRequest.Link))
        //        .WhereIf(systemCreatedListItemPagedRequest.ReleaseDateBegin.HasValue && systemCreatedListItemPagedRequest.ReleaseDateEnd.HasValue,
        //                    x => x.ReleaseDate.IsBetween(systemCreatedListItemPagedRequest.ReleaseDateBegin ?? default, systemCreatedListItemPagedRequest.ReleaseDateEnd ?? default))
        //        .WhereIf(systemCreatedListItemPagedRequest.IsPc.HasValue, x => x.IsPc == systemCreatedListItemPagedRequest.IsPc)
        //        .WhereIf(systemCreatedListItemPagedRequest.IsXBox.HasValue, x => x.IsXBox == systemCreatedListItemPagedRequest.IsXBox)
        //        .WhereIf(systemCreatedListItemPagedRequest.IsPs.HasValue, x => x.IsPs == systemCreatedListItemPagedRequest.IsPs)
        //        .WhereIf(systemCreatedListItemPagedRequest.IsVideo.HasValue, x => x.IsVideo == systemCreatedListItemPagedRequest.IsVideo)
        //        .WhereIf(systemCreatedListItemPagedRequest.SystemCreatedListId.HasValue, x => x.SystemCreatedListId == systemCreatedListItemPagedRequest.SystemCreatedListId);
        //}

        //public async Task<SystemCreatedListItemDto> GetSystemCreatedListItem(SystemCreatedListItemPagedRequestDto systemCreatedListItemPagedRequest)
        //{
        //    CheckGetPermission();

        //    var systemCreatedListItemEntity = await QueryableSystemCreatedListItem(systemCreatedListItemPagedRequest).FirstOrDefaultAsync();
        //    return ObjectMapper.Map<SystemCreatedListItemDto>(systemCreatedListItemEntity);
        //}

        //public async Task<List<SystemCreatedListItemDto>> GetSystemCreatedListItemList(SystemCreatedListItemPagedRequestDto systemCreatedListItemPagedRequest)
        //{
        //    CheckGetPermission();

        //    var systemCreatedListItemEntity = await QueryableSystemCreatedListItem(systemCreatedListItemPagedRequest).ToListAsync();
        //    return ObjectMapper.Map<List<SystemCreatedListItemDto>>(systemCreatedListItemEntity);
        //}

        //public async Task<SystemCreatedListItemDto> CreateSystemCreatedListItem(CreateSystemCreatedListItemDto createSystemCreatedListItem)
        //{
        //    CheckCreatePermission();

        //    var createSystemCreatedListItemEntity = ObjectMapper.Map<SystemCreatedListItemEntity>(createSystemCreatedListItem);
        //    var newCreatedEntity = await _systemCreatedListItemRepository.InsertAsync(createSystemCreatedListItemEntity);

        //    return ObjectMapper.Map<SystemCreatedListItemDto>(newCreatedEntity);
        //}
    }
}