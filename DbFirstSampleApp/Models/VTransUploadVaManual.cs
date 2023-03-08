using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTransUploadVaManual
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("kode_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("jenis_transaksi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisTransaksi { get; set; }
        [Column("nominal_va")]
        public double? NominalVa { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("upload_id")]
        public int? UploadId { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
        [Column("id_jenis_tagihan")]
        public int? IdJenisTagihan { get; set; }
        [Column("status_tagihan")]
        public int? StatusTagihan { get; set; }
        [Column("status_approve")]
        public short? StatusApprove { get; set; }
        [Column("approve_by")]
        [Unicode(false)]
        public string? ApproveBy { get; set; }
        [Column("approve_date", TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("tipe_bisnis")]
        public short? TipeBisnis { get; set; }
        [Column("jenis_biaya")]
        public short? JenisBiaya { get; set; }
        [Column("nama_tipe_bisnis")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaTipeBisnis { get; set; }
    }
}
