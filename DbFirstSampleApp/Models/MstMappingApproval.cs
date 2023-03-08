using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_mapping_approval")]
    public partial class MstMappingApproval
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("username_request")]
        [StringLength(255)]
        [Unicode(false)]
        public string? UsernameRequest { get; set; }
        [Column("username_approve")]
        [StringLength(255)]
        [Unicode(false)]
        public string? UsernameApprove { get; set; }
        [Column("active")]
        public int? Active { get; set; }
    }
}
