using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("List_Upload")]
    public partial class ListUpload
    {
        [Key]
        [Column("UploadID", TypeName = "numeric(18, 0)")]
        public decimal UploadId { get; set; }
        [Column("Tgl_upload", TypeName = "datetime")]
        public DateTime? TglUpload { get; set; }
        [Column("Jumlah_Registration", TypeName = "numeric(18, 0)")]
        public decimal? JumlahRegistration { get; set; }
        [Column("un_process", TypeName = "numeric(18, 0)")]
        public decimal? UnProcess { get; set; }
        [Column("total", TypeName = "numeric(18, 0)")]
        public decimal? Total { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cabang { get; set; }
        [Column("User_Upload")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserUpload { get; set; }
        [Column("User_verifikator")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserVerifikator { get; set; }
        [Column("Tgl_verifikator", TypeName = "datetime")]
        public DateTime? TglVerifikator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("User_verifikasi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserVerifikasi { get; set; }
        [Column("tgl_verifikasi", TypeName = "datetime")]
        public DateTime? TglVerifikasi { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("AAJI_clear", TypeName = "numeric(18, 0)")]
        public decimal? AajiClear { get; set; }
        [Column("AAJI_CPD", TypeName = "numeric(18, 0)")]
        public decimal? AajiCpd { get; set; }
        [Column("AAJI_Fail", TypeName = "numeric(18, 0)")]
        public decimal? AajiFail { get; set; }
    }
}
