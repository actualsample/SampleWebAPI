using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VDaftarTagihanCpdNew
    {
        [Column("id_tagihan")]
        public int IdTagihan { get; set; }
        [Column("description")]
        [Unicode(false)]
        public string? Description { get; set; }
        [Column("jenis_trans")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisTrans { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("status_paid")]
        public int? StatusPaid { get; set; }
        [Column("total_gross")]
        public double? TotalGross { get; set; }
        [Column("total_net")]
        public double? TotalNet { get; set; }
        [Column("total_pajak")]
        public double? TotalPajak { get; set; }
        [Column("total_cover_biaya")]
        public double? TotalCoverBiaya { get; set; }
        [Column("nominal_transfer")]
        public double? NominalTransfer { get; set; }
        [Column("no_inv")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInv { get; set; }
        [Column("status_batch_inv")]
        public short? StatusBatchInv { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("kode_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("id_mutasi")]
        public int? IdMutasi { get; set; }
        [Column("used_amount_va")]
        public double? UsedAmountVa { get; set; }
        [Column("suspent_amount_va")]
        public double? SuspentAmountVa { get; set; }
        [Column("nama_jenis_transaksi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTransaksi { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("last_update_fms", TypeName = "datetime")]
        public DateTime? LastUpdateFms { get; set; }
        [Column("paid_date", TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
    }
}
