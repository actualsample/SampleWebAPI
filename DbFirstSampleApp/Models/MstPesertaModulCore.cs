using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_peserta_modul_core")]
    public partial class MstPesertaModulCore
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("user_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("expiry_date", TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("status_data")]
        public short? StatusData { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("status_tagihan")]
        public short? StatusTagihan { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
