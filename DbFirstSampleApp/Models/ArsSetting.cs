using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ARS_settings")]
    public partial class ArsSetting
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TYPE")]
        public int? Type { get; set; }
        [Column("NAME")]
        [StringLength(300)]
        public string? Name { get; set; }
        [Column("USERNAME")]
        [StringLength(300)]
        public string? Username { get; set; }
        [Column("COOKIE")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Cookie { get; set; }
        [Column("SEARCH", TypeName = "ntext")]
        public string? Search { get; set; }
        [Column("TABLENAME")]
        [StringLength(300)]
        [Unicode(false)]
        public string? Tablename { get; set; }
    }
}
