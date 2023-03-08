using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("History_tgl_ujian")]
    public partial class HistoryTglUjian
    {
        [Column("IDUPD", TypeName = "numeric(18, 0)")]
        public decimal? Idupd { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("createdate", TypeName = "datetime")]
        public DateTime? Createdate { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("kota_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KotaUjian { get; set; }
    }
}
