using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("TRX_PENGKINIAN_AGEN")]
    public partial class TrxPengkinianAgen
    {
        [Key]
        [Column("NO_PENGAJUAN")]
        [StringLength(150)]
        [Unicode(false)]
        public string NoPengajuan { get; set; } = null!;
        [Column("ID_MEMBER")]
        [StringLength(50)]
        [Unicode(false)]
        public string? IdMember { get; set; }
        [Column("KODE_AGEN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgen { get; set; }
        [Column("NAMA_AGEN")]
        [StringLength(150)]
        [Unicode(false)]
        public string? NamaAgen { get; set; }
        [Column("NIK")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nik { get; set; }
        [Column("ALAMAT")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Alamat { get; set; }
        [Column("PROVINSI")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Provinsi { get; set; }
        [Column("PROVINSI_CODE")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProvinsiCode { get; set; }
        [Column("KAB_KOTA")]
        [StringLength(150)]
        [Unicode(false)]
        public string? KabKota { get; set; }
        [Column("KECAMATAN")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Kecamatan { get; set; }
        [Column("KELURAHAN")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Kelurahan { get; set; }
        [Column("RT")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Rt { get; set; }
        [Column("RW")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Rw { get; set; }
        [Column("KODE_POS")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodePos { get; set; }
        [Column("HP")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Hp { get; set; }
        [Column("EMAIL")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("FILE_SPK")]
        [StringLength(500)]
        [Unicode(false)]
        public string? FileSpk { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("LAST_UPDATE", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Column("KETERANGAN")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Keterangan { get; set; }
        [Column("MOTIVASI")]
        [StringLength(5000)]
        [Unicode(false)]
        public string? Motivasi { get; set; }
        [Column("TWITTER")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Twitter { get; set; }
        [Column("INSTAGRAM")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Instagram { get; set; }
        [Column("FACEBOOK")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Facebook { get; set; }
        [Column("LAINNYA")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Lainnya { get; set; }
        [Column("FILE_FOTO")]
        [StringLength(500)]
        [Unicode(false)]
        public string? FileFoto { get; set; }
        [Column("UPDATE_BY")]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        /// <summary>
        /// 1 = Pengkinian SPK
        /// 0 = Pengkinian Data
        /// </summary>
        [Column("JENIS_PENGAJUAN")]
        public int JenisPengajuan { get; set; }
    }
}
