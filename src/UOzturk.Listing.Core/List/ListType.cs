using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOzturk.Listing.List
{
    [Table("ListType")]
    public class ListType : FullAuditedEntity, IFullAudited
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<UserCreatedList> UserCreatedList { get; set; }

        public ICollection<SystemCreatedList> SystemCreatedListCollection { get; set; }
    }
}