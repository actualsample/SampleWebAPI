using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ars_ugrights")]
    public partial class ArsUgright
    {
        [Key]
        [StringLength(300)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        [Key]
        [Column("GroupID")]
        public int GroupId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? AccessMask { get; set; }
    }
}
