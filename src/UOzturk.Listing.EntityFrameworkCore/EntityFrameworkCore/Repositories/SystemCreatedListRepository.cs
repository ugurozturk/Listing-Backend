using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public List<SystemCreatedListEntity> GetAllWithItems(int? ListTypeId)
        {
            var query = GetAll();

            if (ListTypeId.HasValue)
            {
                query = query.Where(x => x.ListTypeId == ListTypeId.Value);
            }

            return query
                .Include(x => x.ListType)
                .Include(x => x.SystemCreatedListItemCollection)//.ThenInclude(cs=>cs.SystemCreatedList)
                .ToList();
        }
    }
}
