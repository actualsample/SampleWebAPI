using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTglUjianAr
    {
        [Column("hari_ujian")]
        [StringLength(30)]
        public string? HariUjian { get; set; }
        [Column("tgl", TypeName = "datetime")]
        public DateTime? Tgl { get; set; }
        [Column("kota")]
        [StringLength(40)]
        public string? Kota { get; set; }
        [Column("Lokasi_Ujian_PAPER")]
        [StringLength(50)]
        public string? LokasiUjianPaper { get; set; }
        [Column("TGL_BATAS", TypeName = "datetime")]
        public DateTime? TglBatas { get; set; }
        [Column("IDUPD", TypeName = "numeric(18, 0)")]
        public decimal? Idupd { get; set; }
    }
}
