using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UOzturk.Listing.DefinitionTypes.SystemCreatedList;
using UOzturk.Listing.IRepositories;
using UOzturk.Listing.List;

namespace UOzturk.Listing.EntityFrameworkCore.Repositories
{
    public class SystemCreatedListRepository : ListingRepositoryBase<SystemCreatedListEntity>, ISystemCreatedListRepository
    {
        public SystemCreatedListRepository(IDbContextProvider<ListingDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// TODO: UĞUR  buranın test edilmesi gerekiyor.
        /// </summary>
        /// <param name="ListTypeId"></param>
        /// <returns></returns>
        public List<SystemCreatedListEntity> GetAllWithItems(SystemCreatedListPagedRequestDto input)
        {
            var query = GetAll();

            if (input.ListTypeId.HasValue)
            {
                query = query.Where(x => x.ListTypeId == input.ListTypeId.Value);
            }

            query = query.Skip(input.SkipCount);

            if (input.MaxResultCount.HasValue)
            {
                query = query.Take(input.MaxResultCount.Value);
            }

            return query.ToList();
        }
    }
}
