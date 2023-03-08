using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("tbl_data")]
    public partial class TblDatum
    {
        [Column("No Urut")]
        [StringLength(255)]
        public string? NoUrut { get; set; }
        [Column("Nama Tenaga Pemasar (Agen)")]
        [StringLength(255)]
        public string? NamaTenagaPemasarAgen { get; set; }
        [Column("Kode Tenaga Pemasar (Agen)")]
        [StringLength(255)]
        public string? KodeTenagaPemasarAgen { get; set; }
        [Column("Alamat Rumah")]
        [StringLength(255)]
        public string? AlamatRumah { get; set; }
        [Column("Home City")]
        [StringLength(255)]
        public string? HomeCity { get; set; }
        [Column("No HP (Telepon)")]
        [StringLength(255)]
        public string? NoHpTelepon { get; set; }
        [Column("No KTP")]
        [StringLength(255)]
        public string? NoKtp { get; set; }
        [Column("Kota Kelahiran")]
        [StringLength(255)]
        public string? KotaKelahiran { get; set; }
        [Column("Tanggal Lahir", TypeName = "datetime")]
        public DateTime? TanggalLahir { get; set; }
        [Column("Jenis Kelamin")]
        [StringLength(255)]
        public string? JenisKelamin { get; set; }
        [Column("Status Perkawinan")]
        [StringLength(255)]
        public string? StatusPerkawinan { get; set; }
        [StringLength(255)]
        public string? Agama { get; set; }
        [Column("Pendidikan Terakhir")]
        [StringLength(255)]
        public string? PendidikanTerakhir { get; set; }
        [Column("Office City")]
        [StringLength(255)]
        public string? OfficeCity { get; set; }
        [StringLength(255)]
        public string? Jabatan { get; set; }
        [Column("Nama Atasan Langsung")]
        [StringLength(255)]
        public string? NamaAtasanLangsung { get; set; }
        [Column("Join Date", TypeName = "datetime")]
        public DateTime? JoinDate { get; set; }
        [Column("Industry Entry Date", TypeName = "datetime")]
        public DateTime? IndustryEntryDate { get; set; }
        [Column("Product Type")]
        [StringLength(255)]
        public string? ProductType { get; set; }
    }
}
