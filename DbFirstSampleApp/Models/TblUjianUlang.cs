using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("tbl_ujian_ulang")]
    public partial class TblUjianUlang
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("no_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoAgent { get; set; }
        [Column("nama_agent")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("no_ktp")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoKtp { get; set; }
        [Column("tempat_lahir")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TempatLahir { get; set; }
        [Column("tgl_lahir", TypeName = "datetime")]
        public DateTime? TglLahir { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("status_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusUjian { get; set; }
    }
}
