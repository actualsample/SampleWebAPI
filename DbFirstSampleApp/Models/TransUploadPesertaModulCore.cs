using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("trans_upload_peserta_modul_core")]
    public partial class TransUploadPesertaModulCore
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("upload_id")]
        public int? UploadId { get; set; }
        [Column("kd_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KdAgent { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("nama_modul_core")]
        [Unicode(false)]
        public string? NamaModulCore { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
    }
}
