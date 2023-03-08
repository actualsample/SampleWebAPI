using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTglUjian
    {
        [Column("HARI")]
        [StringLength(6)]
        [Unicode(false)]
        public string Hari { get; set; } = null!;
        [Column("tgl", TypeName = "datetime")]
        public DateTime? Tgl { get; set; }
        [Column("batas", TypeName = "datetime")]
        public DateTime? Batas { get; set; }
        [Column("jenis")]
        [StringLength(6)]
        [Unicode(false)]
        public string Jenis { get; set; } = null!;
    }
}
