using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VMenu
    {
        [Column("id_user")]
        public int IdUser { get; set; }
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
        [Column("id_menu")]
        public int IdMenu { get; set; }
        [Column("nama")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nama { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("url")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Url { get; set; }
        [Column("class")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Class { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
    }
}
