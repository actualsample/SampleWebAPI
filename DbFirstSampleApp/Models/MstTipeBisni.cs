using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_tipe_bisnis")]
    public partial class MstTipeBisni
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nama_tipe_bisnis")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaTipeBisnis { get; set; }
        [Column("status_flag")]
        public int? StatusFlag { get; set; }
    }
}
