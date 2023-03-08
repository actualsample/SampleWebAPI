using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("tbl_hasil_ujian")]
    public partial class TblHasilUjian
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAMA AGEN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaAgen { get; set; }
        [Column("KODE AGEN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgen { get; set; }
        [Column("KODE AGEN2")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgen2 { get; set; }
        [Column("KODE UJIAN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeUjian { get; set; }
        [Column("LOKASI UJIAN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("TANGGAL UJIAN", TypeName = "datetime")]
        public DateTime? TanggalUjian { get; set; }
        [Column("SESI UJIAN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SesiUjian { get; set; }
        [Column("PRODUK UJIAN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProdukUjian { get; set; }
        [Column("HASIL UJIAN")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HasilUjian { get; set; }
        [Column("AAJI CODE")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AajiCode { get; set; }
        [Column("AASI CODE")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AasiCode { get; set; }
        [Column("NOMOR SERTIFIKAT")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NomorSertifikat { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
