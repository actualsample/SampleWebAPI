using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VDetailBatchInv
    {
        [Column("id_detail")]
        public int IdDetail { get; set; }
        [Column("id_batch_inv")]
        public int? IdBatchInv { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("status_paid")]
        public int? StatusPaid { get; set; }
        [Column("paid_date", TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
        [Column("id_detail_tagihan")]
        public int? IdDetailTagihan { get; set; }
        [Column("kode_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("item")]
        [Unicode(false)]
        public string? Item { get; set; }
        [Column("gross")]
        public double? Gross { get; set; }
        [Column("net")]
        public double? Net { get; set; }
        [Column("pajak")]
        public double? Pajak { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("jenis_tagihan")]
        public int? JenisTagihan { get; set; }
        [Column("cover_biaya")]
        public double? CoverBiaya { get; set; }
        [Column("nominal_transfer")]
        public double? NominalTransfer { get; set; }
        [Column("nama_jenis_tagihan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTagihan { get; set; }
        [Column("jenis_transaksi")]
        public short? JenisTransaksi { get; set; }
    }
}
