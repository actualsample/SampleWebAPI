using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VDigitalKey
    {
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("user_modul_core")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserModulCore { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("expiry_date", TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}
