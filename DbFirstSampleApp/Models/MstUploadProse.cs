using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_upload_proses")]
    public partial class MstUploadProse
    {
        [Key]
        [Column("id_proses")]
        public int IdProses { get; set; }
        [Column("proses")]
        public int? Proses { get; set; }
        [Column("un_proses")]
        public int? UnProses { get; set; }
        [Column("total")]
        public int? Total { get; set; }
        [Column("create_by")]
        [StringLength(30)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
    }
}
