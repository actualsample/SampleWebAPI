using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("tbl_konf_ujian")]
    public partial class TblKonfUjian
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("method")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Method { get; set; }
        [Column("city")]
        [StringLength(50)]
        [Unicode(false)]
        public string? City { get; set; }
        [Column("venue")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Venue { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("session", TypeName = "datetime")]
        public DateTime? Session { get; set; }
        [Column("total_participant")]
        public int? TotalParticipant { get; set; }
        [Column("nama_file")]
        [StringLength(255)]
        [Unicode(false)]
        public string? NamaFile { get; set; }
    }
}
