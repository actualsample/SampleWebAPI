using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("tbl_bantuan")]
    public partial class TblBantuan
    {
        [Column("No Urut")]
        public double? NoUrut { get; set; }
        [Column("Nama Tenaga Pemasar (Agen)")]
        [StringLength(255)]
        public string? NamaTenagaPemasarAgen { get; set; }
        [Column("Kode Tenaga Pemasar (Agen)")]
        public double? KodeTenagaPemasarAgen { get; set; }
        [Column("Alamat Rumah")]
        public double? AlamatRumah { get; set; }
        [Column("Home City")]
        public double? HomeCity { get; set; }
        [Column("No HP (Telepon)")]
        public double? NoHpTelepon { get; set; }
        [Column("No KTP")]
        public double? NoKtp { get; set; }
        [Column("Kota Kelahiran")]
        public double? KotaKelahiran { get; set; }
        [Column("Tanggal Lahir")]
        public double? TanggalLahir { get; set; }
        [Column("Jenis Kelamin")]
        public double? JenisKelamin { get; set; }
        [Column("Status Perkawinan")]
        public double? StatusPerkawinan { get; set; }
        public double? Agama { get; set; }
        [Column("Pendidikan Terakhir")]
        public double? PendidikanTerakhir { get; set; }
        [Column("Office City")]
        public double? OfficeCity { get; set; }
        public double? Jabatan { get; set; }
        [Column("Nama Atasan Langsung")]
        public double? NamaAtasanLangsung { get; set; }
        [Column("Join Date")]
        public double? JoinDate { get; set; }
        [Column("Industry Entry Date")]
        public double? IndustryEntryDate { get; set; }
        [Column("Product Type")]
        public double? ProductType { get; set; }
        [StringLength(255)]
        public string? F20 { get; set; }
        [StringLength(255)]
        public string? F21 { get; set; }
        [StringLength(255)]
        public string? F22 { get; set; }
    }
}
