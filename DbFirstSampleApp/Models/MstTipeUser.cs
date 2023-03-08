using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_tipe_user")]
    public partial class MstTipeUser
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("tipe_user")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TipeUser { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
