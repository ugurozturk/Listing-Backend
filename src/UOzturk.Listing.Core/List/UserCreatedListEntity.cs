using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UOzturk.Listing.Authorization.Users;

namespace UOzturk.Listing.List
{
    [Table("UserCreatedList")]
    public class UserCreatedListEntity : FullAuditedEntity, IFullAudited
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("ListType")]
        public int ListTypeId { get; set; }

        [ForeignKey("User")]
        public long ListOwnerUserId { get; set; }

        public User User { get; set; }

        public ListTypeEntity ListType { get; set; }
    }
}
