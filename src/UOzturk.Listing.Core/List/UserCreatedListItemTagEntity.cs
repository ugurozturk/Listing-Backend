﻿using System;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.List
{
    [Table("UserCreatedListItemTag")]
    public class UserCreatedListItemTagEntity : FullAuditedEntity, IFullAudited
    {
        [MaxLength(25)]
        public string Name { get; set; }

        [ForeignKey("UserCreatedListItem")]
        public int UserCreatedListItemId { get; set; }

        public virtual UserCreatedListItemEntity UserCreatedListItem { get; set; }
    }
}
