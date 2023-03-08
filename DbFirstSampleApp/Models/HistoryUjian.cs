using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("History_ujian")]
    public partial class HistoryUjian
    {
        [Column("Kode_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("createdate", TypeName = "datetime")]
        public DateTime? Createdate { get; set; }
    }
}
