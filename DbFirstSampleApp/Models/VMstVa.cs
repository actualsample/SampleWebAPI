using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VMstVa
    {
        [Column("id_agent")]
        public int IdAgent { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("kode_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("nik")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Nik { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
    }
}
