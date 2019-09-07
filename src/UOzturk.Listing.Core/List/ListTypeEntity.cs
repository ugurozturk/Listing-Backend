using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOzturk.Listing.List
{
    [Table("ListType")]
    public class ListTypeEntity : FullAuditedEntity, IFullAudited
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<UserCreatedListEntity> UserCreatedList { get; set; }

        public virtual ICollection<SystemCreatedListEntity> SystemCreatedListCollection { get; set; }
    }
}