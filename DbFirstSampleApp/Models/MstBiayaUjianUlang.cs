using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_biaya_ujian_ulang")]
    public partial class MstBiayaUjianUlang
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("status_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusUjian { get; set; }
        [Column("keterangan")]
        [Unicode(false)]
        public string? Keterangan { get; set; }
        [Column("nominal")]
        public double? Nominal { get; set; }
        [Column("status_pajak")]
        public int? StatusPajak { get; set; }
        [Column("jenis_tagihan")]
        public int? JenisTagihan { get; set; }
    }
}
