using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ARS_audit")]
    public partial class ArsAudit
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("datetime", TypeName = "datetime")]
        public DateTime Datetime { get; set; }
        [Column("ip")]
        [StringLength(40)]
        [Unicode(false)]
        public string Ip { get; set; } = null!;
        [Column("user")]
        [StringLength(300)]
        [Unicode(false)]
        public string? User { get; set; }
        [Column("table")]
        [StringLength(300)]
        [Unicode(false)]
        public string? Table { get; set; }
        [Column("action")]
        [StringLength(250)]
        [Unicode(false)]
        public string Action { get; set; } = null!;
        [Column("description", TypeName = "text")]
        public string? Description { get; set; }
    }
}
