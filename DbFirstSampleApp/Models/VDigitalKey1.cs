using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VDigitalKey1
    {
        [Column("kode_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("nik")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Nik { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("expired_lisensi", TypeName = "date")]
        public DateTime? ExpiredLisensi { get; set; }
        [Column("modul_awal")]
        public int? ModulAwal { get; set; }
        [Column("modul_akhir")]
        public int? ModulAkhir { get; set; }
        [Column("current_point")]
        public int? CurrentPoint { get; set; }
        [Column("cpd_step")]
        public int? CpdStep { get; set; }
        [Column("status_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusAgent { get; set; }
        [Column("tipe_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TipeAgent { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("status_proses")]
        public short? StatusProses { get; set; }
        [Column("user_aaji")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserAaji { get; set; }
        [Column("pass_aaji")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PassAaji { get; set; }
        [Column("expired_date", TypeName = "date")]
        public DateTime? ExpiredDate { get; set; }
        [Column("url_web_aaji")]
        [StringLength(150)]
        [Unicode(false)]
        public string? UrlWebAaji { get; set; }
        [Column("status_expired")]
        public short? StatusExpired { get; set; }
        [Column("request")]
        public short? Request { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("nama_modul_core")]
        [Unicode(false)]
        public string? NamaModulCore { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
