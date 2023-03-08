using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_channel_CPD")]
    public partial class MstChannelCpd
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("cover_biaya")]
        public double? CoverBiaya { get; set; }
        [Column("status_flag")]
        public int? StatusFlag { get; set; }
    }
}
