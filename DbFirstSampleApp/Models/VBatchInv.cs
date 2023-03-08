using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VBatchInv
    {
        [Column("id_batch_inv")]
        public int IdBatchInv { get; set; }
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
        [Column("total_gross")]
        public double? TotalGross { get; set; }
        [Column("total_net")]
        public double? TotalNet { get; set; }
        [Column("total_pajak")]
        public double? TotalPajak { get; set; }
        [Column("tgl_inv_aaji", TypeName = "datetime")]
        public DateTime? TglInvAaji { get; set; }
        [Column("nominal_inv")]
        public double? NominalInv { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
        [Column("no_pdc")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoPdc { get; set; }
        [Column("tgl_pdc", TypeName = "datetime")]
        public DateTime? TglPdc { get; set; }
        [Column("create_by_pdc")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateByPdc { get; set; }
        [Column("create_date_pdc", TypeName = "datetime")]
        public DateTime? CreateDatePdc { get; set; }
        [Column("nama_jenis_tagihan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTagihan { get; set; }
        [Column("source_data")]
        public short? SourceData { get; set; }
        [Column("nama_jenis_transaksi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTransaksi { get; set; }
    }
}
