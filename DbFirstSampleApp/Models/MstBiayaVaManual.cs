using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_biaya_va_manual")]
    public partial class MstBiayaVaManual
    {
        [Key]
        [Column("id_biaya_va_manual")]
        public int IdBiayaVaManual { get; set; }
        [Column("tipe_bisnis")]
        public int? TipeBisnis { get; set; }
        [Column("jenis_biaya")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisBiaya { get; set; }
        [Column("harga")]
        public double? Harga { get; set; }
        [Column("status_pajak")]
        public short? StatusPajak { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
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
    }
}
