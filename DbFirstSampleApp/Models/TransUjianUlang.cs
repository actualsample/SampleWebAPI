using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("trans_ujian_ulang")]
    public partial class TransUjianUlang
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_trans_va")]
        public int? IdTransVa { get; set; }
        [Column("kode_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [StringLength(255)]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("no_ktp")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoKtp { get; set; }
        [Column("id_mobis")]
        [StringLength(50)]
        [Unicode(false)]
        public string? IdMobis { get; set; }
        [Column("status_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusUjian { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
    }
}
