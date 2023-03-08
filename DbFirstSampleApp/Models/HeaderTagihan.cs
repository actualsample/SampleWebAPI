using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("header_tagihan")]
    public partial class HeaderTagihan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_user")]
        [Unicode(false)]
        public string? IdUser { get; set; }
        [Column("name")]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("kd_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KdAgent { get; set; }
        [Column("no_va")]
        [StringLength(20)]
        [Unicode(false)]
        public string? NoVa { get; set; }
        [Column("no_invoice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInvoice { get; set; }
        [Column("date_invoice", TypeName = "date")]
        public DateTime? DateInvoice { get; set; }
        [Column("date_invoice_finish", TypeName = "date")]
        public DateTime? DateInvoiceFinish { get; set; }
        [Column("description")]
        [Unicode(false)]
        public string? Description { get; set; }
        [Column("total")]
        public double? Total { get; set; }
        [Column("status")]
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("status_paid")]
        [StringLength(10)]
        public string? StatusPaid { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
        [Column("cover_biaya")]
        public double? CoverBiaya { get; set; }
        [Column("nominal_transfer")]
        public double? NominalTransfer { get; set; }
    }
}
