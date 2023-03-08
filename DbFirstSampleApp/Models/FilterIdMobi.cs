using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("filter_id_mobis")]
    public partial class FilterIdMobi
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mobis")]
        [StringLength(20)]
        [Unicode(false)]
        public string? IdMobis { get; set; }
    }
}
