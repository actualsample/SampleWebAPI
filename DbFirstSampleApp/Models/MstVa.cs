using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_va")]
    public partial class MstVa
    {
        [Column("id_agent")]
        public int IdAgent { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
    }
}
