using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("trans_materi")]
    public partial class TransMateri
    {
        [Key]
        [Column("id_trans_materi")]
        public int IdTransMateri { get; set; }
        [Column("id_user")]
        [Unicode(false)]
        public string? IdUser { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("id_materi")]
        public int? IdMateri { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
    }
}
