using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("upload_status_aaji_19")]
    public partial class UploadStatusAaji19
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("No Urut")]
        public string? NoUrut { get; set; }
        [Column("Nama Tenaga Pemasar (Agen)")]
        public string? NamaTenagaPemasarAgen { get; set; }
        [Column("Kode Tenaga Pemasar (Agen)")]
        public string? KodeTenagaPemasarAgen { get; set; }
        [Column("Alamat Rumah")]
        public string? AlamatRumah { get; set; }
        [Column("Home City")]
        public string? HomeCity { get; set; }
        [Column("No HP (Telepon)")]
        public string? NoHpTelepon { get; set; }
        [Column("No KTP")]
        public string? NoKtp { get; set; }
        [Column("Kota Kelahiran")]
        public string? KotaKelahiran { get; set; }
        [Column("Tanggal Lahir", TypeName = "date")]
        public DateTime? TanggalLahir { get; set; }
        [Column("Jenis Kelamin")]
        public string? JenisKelamin { get; set; }
        [Column("Status Perkawinan")]
        public string? StatusPerkawinan { get; set; }
        public string? Agama { get; set; }
        [Column("Pendidikan Terakhir")]
        public string? PendidikanTerakhir { get; set; }
        [Column("Office City")]
        public string? OfficeCity { get; set; }
        public string? Jabatan { get; set; }
        [Column("Nama Atasan Langsung")]
        public string? NamaAtasanLangsung { get; set; }
        [Column("Join Date", TypeName = "date")]
        public DateTime? JoinDate { get; set; }
        [Column("Industry Entry Date", TypeName = "date")]
        public DateTime? IndustryEntryDate { get; set; }
        [Column("Product Type")]
        public string? ProductType { get; set; }
        [Column("Status_AAJI")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusAaji { get; set; }
        [Unicode(false)]
        public string? Keterangan { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
