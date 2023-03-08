using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_channel")]
    public partial class MstChannel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("channel")]
        [StringLength(10)]
        public string? Channel { get; set; }
        [Column("kd_channel")]
        public int? KdChannel { get; set; }
    }
}
