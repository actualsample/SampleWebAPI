using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VSummeryUjian
    {
        [Column("Kota_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KotaUjian { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(255)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("jenis_ujian")]
        [StringLength(15)]
        [Unicode(false)]
        public string? JenisUjian { get; set; }
        [Column("metode")]
        [StringLength(7)]
        public string? Metode { get; set; }
        [Column("hari")]
        [StringLength(6)]
        [Unicode(false)]
        public string? Hari { get; set; }
        [Column("total")]
        public int? Total { get; set; }
    }
}
