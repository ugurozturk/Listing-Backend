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
        public List<SystemCreatedListEntity> GetAllWithItems(int? listTypeId)
        {
            var query = GetAll();

            if (listTypeId.HasValue)
            {
                query = query.Where(x => x.ListTypeId == listTypeId.Value);
            }

            return query.ToList();
        }
    }
}
