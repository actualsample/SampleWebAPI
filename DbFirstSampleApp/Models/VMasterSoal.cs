using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VMasterSoal
    {
        [Column("id_soal")]
        public int IdSoal { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("soal")]
        [Unicode(false)]
        public string? Soal { get; set; }
        [Column("jawaban")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Jawaban { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("create_by")]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("nama_jenis_modul")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisModul { get; set; }
        [Column("status")]
        [StringLength(11)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
