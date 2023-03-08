using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_tagihan")]
    public partial class DetailTagihan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_invoice")]
        public int IdInvoice { get; set; }
        [Column("no")]
        public int? No { get; set; }
        [Column("item")]
        [Unicode(false)]
        public string? Item { get; set; }
        [Column("sub_total")]
        public double? SubTotal { get; set; }
        [Column("status")]
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
    }
}
