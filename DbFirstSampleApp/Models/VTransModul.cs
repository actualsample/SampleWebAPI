using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTransModul
    {
        [Column("id_modul")]
        public int IdModul { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("jenis_modul")]
        public int? JenisModul { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("create_by")]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("jml_soal")]
        public int? JmlSoal { get; set; }
        [Column("nama_jenis_modul")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisModul { get; set; }
        [Column("point")]
        public int? Point { get; set; }
        [Column("id_trans_modul")]
        public int IdTransModul { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("score")]
        public int? Score { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("finish_modul", TypeName = "datetime")]
        public DateTime? FinishModul { get; set; }
    }
}
