using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VJawaban
    {
        [Column("id_jawaban")]
        public int IdJawaban { get; set; }
        [Column("id_soal")]
        public int? IdSoal { get; set; }
        [Column("pilihan")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Pilihan { get; set; }
        [Column("isi")]
        [Unicode(false)]
        public string? Isi { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("status")]
        [StringLength(11)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
