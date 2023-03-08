using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("trans_rekon")]
    public partial class TransRekon
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mutasi")]
        public int? IdMutasi { get; set; }
        [Column("id_tagihan")]
        public int? IdTagihan { get; set; }
        [Column("used_amount")]
        public double? UsedAmount { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
    }
}
