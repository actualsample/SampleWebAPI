using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("trans_modul")]
    public partial class TransModul
    {
        [Key]
        [Column("id_trans_modul")]
        public int IdTransModul { get; set; }
        [Column("id_user")]
        [Unicode(false)]
        public string? IdUser { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("score")]
        public int? Score { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("finish_modul", TypeName = "datetime")]
        public DateTime? FinishModul { get; set; }
    }
}
