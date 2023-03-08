using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_tanggal_ok")]
    public partial class MstTanggalOk
    {
        [Key]
        [Column("NO")]
        public int No { get; set; }
        [Column("SELASA", TypeName = "datetime")]
        public DateTime? Selasa { get; set; }
        [Column("KAMIS", TypeName = "datetime")]
        public DateTime? Kamis { get; set; }
        [Column("M10-SELASA", TypeName = "datetime")]
        public DateTime? M10Selasa { get; set; }
        [Column("M10-KAMIS", TypeName = "datetime")]
        public DateTime? M10Kamis { get; set; }
        [Column("SABTU", TypeName = "datetime")]
        public DateTime? Sabtu { get; set; }
        [Column("MINGGU", TypeName = "datetime")]
        public DateTime? Minggu { get; set; }
        [Column("M10-ONLINE", TypeName = "datetime")]
        public DateTime? M10Online { get; set; }
        [Column("M16-PAPER", TypeName = "datetime")]
        public DateTime? M16Paper { get; set; }
    }
}
