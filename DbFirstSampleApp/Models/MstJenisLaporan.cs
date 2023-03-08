using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_jenis_laporan")]
    public partial class MstJenisLaporan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("jenis_laporan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisLaporan { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
