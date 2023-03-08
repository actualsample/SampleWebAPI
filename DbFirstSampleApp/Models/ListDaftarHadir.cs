using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("list_daftar_hadir")]
    public partial class ListDaftarHadir
    {
        [Key]
        [Column("batch_id")]
        public int BatchId { get; set; }
        [Column("no_inv_internal")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInvInternal { get; set; }
        [Column("no_inv_internal_date", TypeName = "datetime")]
        public DateTime? NoInvInternalDate { get; set; }
        [Column("no_inv_reprint")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInvReprint { get; set; }
        [Column("no_inv_reprint_date", TypeName = "datetime")]
        public DateTime? NoInvReprintDate { get; set; }
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
        [Column("channel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [Column("paid_internal_by")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidInternalBy { get; set; }
        [Column("paid_internal_date", TypeName = "datetime")]
        public DateTime? PaidInternalDate { get; set; }
        [Column("paid_reprint_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PaidReprintBy { get; set; }
        [Column("paid_reprint_date", TypeName = "datetime")]
        public DateTime? PaidReprintDate { get; set; }
    }
}
