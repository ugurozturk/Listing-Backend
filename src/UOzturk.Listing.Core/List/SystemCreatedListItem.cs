using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UOzturk.Listing.List
{
    [Table("SystemCreatedListItem")]
    public class SystemCreatedListItemEntity : FullAuditedEntity, IFullAudited
    {
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Link { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsPc { get; set; }

        public bool IsXBox { get; set; }

        public bool IsPs { get; set; }

        public bool IsVideo { get; set; }

        [ForeignKey("SystemCreatedList")]
        public int SystemCreatedListId { get; set; }

        public SystemCreatedListEntity SystemCreatedList { get; set; }
    }
}
