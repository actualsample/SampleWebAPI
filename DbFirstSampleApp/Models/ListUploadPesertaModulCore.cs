using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("list_upload_peserta_modul_core")]
    public partial class ListUploadPesertaModulCore
    {
        [Key]
        [Column("upload_id")]
        public int UploadId { get; set; }
        [Column("nama_file_upload")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaFileUpload { get; set; }
        [Column("nama_file_proses")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaFileProses { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
    }
}
