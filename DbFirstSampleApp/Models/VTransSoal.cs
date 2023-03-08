using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTransSoal
    {
        [Column("id_trans_soal")]
        public int IdTransSoal { get; set; }
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
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("jenis_modul")]
        public int? JenisModul { get; set; }
        [Column("soal")]
        [Unicode(false)]
        public string? Soal { get; set; }
        [Column("jawaban_benar")]
        [StringLength(1)]
        [Unicode(false)]
        public string? JawabanBenar { get; set; }
        [Column("id_jawaban")]
        public int? IdJawaban { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
    }
}
