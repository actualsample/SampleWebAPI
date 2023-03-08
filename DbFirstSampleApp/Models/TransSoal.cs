using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("trans_soal")]
    public partial class TransSoal
    {
        [Key]
        [Column("id_trans_soal")]
        public int IdTransSoal { get; set; }
        [Column("id_user")]
        [Unicode(false)]
        public string? IdUser { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
        [Column("id_soal")]
        public int? IdSoal { get; set; }
        [Column("jawaban")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Jawaban { get; set; }
        [Column("status_jawaban")]
        public short? StatusJawaban { get; set; }
        [Column("id_jawaban")]
        public int? IdJawaban { get; set; }
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
