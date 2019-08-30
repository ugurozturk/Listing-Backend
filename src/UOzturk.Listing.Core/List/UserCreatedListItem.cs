using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOzturk.Listing.List
{
    [Table("UserCreatedListItem")]
    public class UserCreatedListItem : FullAuditedEntity, IFullAudited
    {
        [MaxLength(200)]
        public string Name { get; set; }

        public short Score { get; set; }

        [ForeignKey("UserCreatedList")]
        public int? UserCreatedListId { get; set; }

        [ForeignKey("SystemCreatedListItem")]
        public int SystemCreatedListItemId { get; set; }

        public UserCreatedList UserCreatedList { get; set; }

        public SystemCreatedListItem SystemCreatedListItem { get; set; }
    }
}