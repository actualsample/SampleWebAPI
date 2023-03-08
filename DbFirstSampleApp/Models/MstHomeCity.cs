using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_home_city")]
    public partial class MstHomeCity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("home_city")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HomeCity { get; set; }
    }
}
