using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("tbl_mutasi_fms")]
    public partial class TblMutasiFm
    {
        [Column("mutasi_id_fms")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MutasiIdFms { get; set; }
        [Column("suspent_amount")]
        public double? SuspentAmount { get; set; }
        [Column("used_amount")]
        public double? UsedAmount { get; set; }
        [Column("paid_date", TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("no_va")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
    }
}
