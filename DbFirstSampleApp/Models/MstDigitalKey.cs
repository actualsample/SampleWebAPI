using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_digital_key")]
    public partial class MstDigitalKey
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        [StringLength(10)]
        [Unicode(false)]
        public string? UserId { get; set; }
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
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("nama_modul_core")]
        [Unicode(false)]
        public string? NamaModulCore { get; set; }
    }
}
