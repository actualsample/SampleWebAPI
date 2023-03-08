using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("batch_inv")]
    public partial class BatchInv
    {
        [Column("id_batch_inv")]
        public int IdBatchInv { get; set; }
        [Column("jenis_trans")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisTrans { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("no_inv_aaji")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInvAaji { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("status_pdc")]
        public short? StatusPdc { get; set; }
        [Column("tgl_inv_aaji", TypeName = "datetime")]
        public DateTime? TglInvAaji { get; set; }
        [Column("update_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("nominal_inv")]
        public double? NominalInv { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
        [Column("id_jenis_trans")]
        public int? IdJenisTrans { get; set; }
        [Column("source_data")]
        public short? SourceData { get; set; }
    }
}
