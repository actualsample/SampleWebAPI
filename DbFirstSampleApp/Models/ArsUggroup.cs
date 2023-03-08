using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ars_uggroups")]
    public partial class ArsUggroup
    {
        [Key]
        [Column("GroupID")]
        public int GroupId { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? Label { get; set; }
    }
}
