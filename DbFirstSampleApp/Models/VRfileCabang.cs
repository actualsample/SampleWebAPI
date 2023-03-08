using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VRfileCabang
    {
        [Column("IDUPD", TypeName = "numeric(18, 0)")]
        public decimal Idupd { get; set; }
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
        [Column("Tanggal Lahir", TypeName = "date")]
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
        [Column("Join Date", TypeName = "date")]
        public DateTime? JoinDate { get; set; }
        [Column("Industry Entry Date", TypeName = "date")]
        public DateTime? IndustryEntryDate { get; set; }
        [Column("Product Type")]
        [StringLength(255)]
        public string? ProductType { get; set; }
        [Column("UploadID", TypeName = "numeric(18, 0)")]
        public decimal? UploadId { get; set; }
        [Column("KTP")]
        public string? Ktp { get; set; }
        public string? Photo { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("Last_Update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Keterangan { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? UploadFile { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("Status_AAJI")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusAaji { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cabang { get; set; }
        [Column("Expired_Lisensi", TypeName = "datetime")]
        public DateTime? ExpiredLisensi { get; set; }
        [Column("AAJI_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AajiLisensi { get; set; }
        [Column("Kota_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KotaUjian { get; set; }
        [Column("Jenis_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisUjian { get; set; }
        [Column("Tarif_Ujian", TypeName = "numeric(18, 0)")]
        public decimal? TarifUjian { get; set; }
        [Column("Tgl_bayar", TypeName = "datetime")]
        public DateTime? TglBayar { get; set; }
        [Column("Bukti_Transfer")]
        [StringLength(255)]
        [Unicode(false)]
        public string? BuktiTransfer { get; set; }
        [Column("PID", TypeName = "numeric(18, 0)")]
        public decimal? Pid { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("Hari_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HariUjian { get; set; }
        [Column("Status_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusUjian { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(255)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("Status_tgl")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusTgl { get; set; }
        [Column("session_ujian", TypeName = "datetime")]
        public DateTime? SessionUjian { get; set; }
        [Column("hist_tgl_ujian", TypeName = "datetime")]
        public DateTime? HistTglUjian { get; set; }
        [Column("id_mobis")]
        [StringLength(50)]
        public string? IdMobis { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("akte_ijasah")]
        public string? AkteIjasah { get; set; }
        [Column("kk")]
        public string? Kk { get; set; }
        [Column("dokumen_lain")]
        public string? DokumenLain { get; set; }
        [Column("ket_tgl")]
        [Unicode(false)]
        public string? KetTgl { get; set; }
        [Column("lampiran_spk")]
        [Unicode(false)]
        public string? LampiranSpk { get; set; }
    }
}
