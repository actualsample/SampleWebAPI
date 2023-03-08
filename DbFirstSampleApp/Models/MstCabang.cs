using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_cabang")]
    public partial class MstCabang
    {
        [Key]
        [Column("IDCBG", TypeName = "numeric(18, 0)")]
        public decimal Idcbg { get; set; }
        [Column("cabang")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cabang { get; set; }
    }
}
