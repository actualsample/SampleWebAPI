using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_soal")]
    public partial class MstSoal
    {
        [Key]
        [Column("id_soal")]
        public int IdSoal { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("soal")]
        [Unicode(false)]
        public string? Soal { get; set; }
        [Column("jawab_a")]
        [Unicode(false)]
        public string? JawabA { get; set; }
        [Column("jawab_b")]
        [Unicode(false)]
        public string? JawabB { get; set; }
        [Column("jawab_c")]
        [Unicode(false)]
        public string? JawabC { get; set; }
        [Column("jawab_d")]
        [Unicode(false)]
        public string? JawabD { get; set; }
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
    }
}
