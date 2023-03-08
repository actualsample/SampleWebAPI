using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_menu")]
    public partial class MstMenu
    {
        [Column("id")]
        public int Id { get; set; }
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
