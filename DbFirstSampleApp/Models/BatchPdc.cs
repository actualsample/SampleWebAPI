using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("batch_pdc")]
    public partial class BatchPdc
    {
        [Column("id_batch_pdc")]
        public int IdBatchPdc { get; set; }
        [Column("no_pdc")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoPdc { get; set; }
        [Column("tgl_pdc", TypeName = "datetime")]
        public DateTime? TglPdc { get; set; }
        [Column("no_acumatica")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoAcumatica { get; set; }
        [Column("tgl_acumatica", TypeName = "datetime")]
        public DateTime? TglAcumatica { get; set; }
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
        [Column("status_done")]
        public short? StatusDone { get; set; }
        [Column("update_by_done")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdateByDone { get; set; }
        [Column("update_date_done", TypeName = "datetime")]
        public DateTime? UpdateDateDone { get; set; }
        [Column("source_data")]
        public short? SourceData { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
    }
}
