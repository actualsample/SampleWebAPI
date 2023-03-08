using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_tarifujian")]
    public partial class MstTarifujian
    {
        [Key]
        [Column("LID")]
        public int Lid { get; set; }
        public double? No { get; set; }
        [StringLength(40)]
        public string? Kota { get; set; }
        [Column("Lokasi_Ujian_PAPER")]
        [StringLength(50)]
        public string? LokasiUjianPaper { get; set; }
        [Column("Hari_Ujian")]
        [StringLength(30)]
        public string? HariUjian { get; set; }
        [StringLength(30)]
        public string? Jenis { get; set; }
        public double? Biaya { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? Type { get; set; }
    }
}
