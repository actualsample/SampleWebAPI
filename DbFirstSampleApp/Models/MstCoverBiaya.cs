using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_cover_biaya")]
    public partial class MstCoverBiaya
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StatusAgent { get; set; }
        [Column("tipe_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TipeAgent { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("biaya")]
        public double? Biaya { get; set; }
    }
}
