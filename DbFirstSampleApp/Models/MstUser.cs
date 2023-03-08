using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_user")]
    public partial class MstUser
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
        [Column("active")]
        public int? Active { get; set; }
        [Column("tipe_user")]
        public int? TipeUser { get; set; }
        [Column("full_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FullName { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("last_password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LastPassword { get; set; }
        [Column("status_change_pass")]
        public short? StatusChangePass { get; set; }
    }
}
