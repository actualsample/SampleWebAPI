using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("trans_upload_cpd")]
    public partial class TransUploadCpd
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
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
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("upload_id")]
        public int? UploadId { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
    }
}
