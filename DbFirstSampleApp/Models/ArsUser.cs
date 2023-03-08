using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("ARS_users")]
    public partial class ArsUser
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("username")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column("password")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("fullname")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Fullname { get; set; }
        [Column("groupid")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Groupid { get; set; }
        [Column("active")]
        public int? Active { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cabang { get; set; }
        [Column("group_type_data")]
        [StringLength(10)]
        public string? GroupTypeData { get; set; }
    }
}
