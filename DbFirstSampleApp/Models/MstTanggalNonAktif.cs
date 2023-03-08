using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_tanggal_non_aktif")]
    public partial class MstTanggalNonAktif
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? Kota { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("createdate", TypeName = "datetime")]
        public DateTime? Createdate { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
    }
}
