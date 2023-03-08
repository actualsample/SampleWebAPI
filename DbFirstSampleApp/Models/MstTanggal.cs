using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_tanggal")]
    public partial class MstTanggal
    {
        [Key]
        [Column("NO")]
        public int No { get; set; }
        [StringLength(255)]
        public string? Bulan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Sabtu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Minggu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? M6 { get; set; }
        [Column("m16", TypeName = "datetime")]
        public DateTime? M16 { get; set; }
        [Column("status_aktif")]
        public int? StatusAktif { get; set; }
        [Column("jenis")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Jenis { get; set; }
        [Column("selasa", TypeName = "datetime")]
        public DateTime? Selasa { get; set; }
        [Column("kamis", TypeName = "datetime")]
        public DateTime? Kamis { get; set; }
    }
}
