using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_kd_agen")]
    public partial class MstKdAgen
    {
        [Key]
        [Column("kd_agen")]
        [StringLength(7)]
        public string KdAgen { get; set; } = null!;
        [Column("idupd")]
        public int? Idupd { get; set; }
        [Column("no_ktp")]
        [StringLength(20)]
        [Unicode(false)]
        public string? NoKtp { get; set; }
    }
}
