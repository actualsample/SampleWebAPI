using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VMstPesertaCpd
    {
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
        [Column("tipe_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TipeAgent { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("status_data")]
        public short? StatusData { get; set; }
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
        [Column("budget_cover")]
        public double? BudgetCover { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("expired_lisensi", TypeName = "date")]
        public DateTime? ExpiredLisensi { get; set; }
        [Column("expired_lisensi_new", TypeName = "date")]
        public DateTime? ExpiredLisensiNew { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("nama_jenis_transaksi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTransaksi { get; set; }
        [Column("nominal_va")]
        public double? NominalVa { get; set; }
        [Column("jenis_transaksi")]
        public short? JenisTransaksi { get; set; }
        [Column("tipe_bisnis")]
        public short? TipeBisnis { get; set; }
        [Column("jenis_biaya")]
        public short? JenisBiaya { get; set; }
        [Column("id_mobis")]
        [StringLength(50)]
        [Unicode(false)]
        public string? IdMobis { get; set; }
    }
}
