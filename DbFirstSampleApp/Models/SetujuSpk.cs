using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("SETUJU_SPK")]
    public partial class SetujuSpk
    {
        [Key]
        [Column("KODE_AGEN")]
        [StringLength(50)]
        [Unicode(false)]
        public string KodeAgen { get; set; } = null!;
        [Column("FLAG_SETUJU")]
        public int? FlagSetuju { get; set; }
        [Column("TGL_SETUJU", TypeName = "datetime")]
        public DateTime? TglSetuju { get; set; }
    }
}
