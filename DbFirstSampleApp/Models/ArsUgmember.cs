using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ars_ugmembers")]
    public partial class ArsUgmember
    {
        [Key]
        [StringLength(300)]
        [Unicode(false)]
        public string UserName { get; set; } = null!;
        [Key]
        [Column("GroupID")]
        public int GroupId { get; set; }
    }
}
