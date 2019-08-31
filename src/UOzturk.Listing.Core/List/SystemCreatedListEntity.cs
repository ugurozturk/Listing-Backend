using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOzturk.Listing.List
{
    [Table("SystemCreatedList")]
    public class SystemCreatedListEntity : FullAuditedEntity, IFullAudited
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("ListType")]
        public int ListTypeId { get; set; }

        public ListTypeEntity ListType { get; set; }

        public ICollection<SystemCreatedListItemEntity> SystemCreatedListItemCollection { get; set; }
    }
}
