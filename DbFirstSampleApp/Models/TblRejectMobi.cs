using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("tbl_reject_mobis")]
    public partial class TblRejectMobi
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mobis")]
        [StringLength(10)]
        public string? IdMobis { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
    }
}
