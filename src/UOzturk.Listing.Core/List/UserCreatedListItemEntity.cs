using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOzturk.Listing.List
{
    [Table("UserCreatedListItem")]
    public class UserCreatedListItemEntity : FullAuditedEntity, IFullAudited
    {
        [MaxLength(200)]
        public string Name { get; set; }

        public short Score { get; set; }

        [ForeignKey("UserCreatedList")]
        public int UserCreatedListId { get; set; }

        [ForeignKey("SystemCreatedListItem")]
        public int? SystemCreatedListItemId { get; set; }

        public virtual UserCreatedListEntity UserCreatedList { get; set; }

        public virtual SystemCreatedListItemEntity SystemCreatedListItem { get; set; }
    }
}