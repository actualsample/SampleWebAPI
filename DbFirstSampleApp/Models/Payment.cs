using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("Payment")]
    public partial class Payment
    {
        [Column("PID", TypeName = "numeric(18, 0)")]
        public decimal Pid { get; set; }
        [Column("BatchID", TypeName = "numeric(18, 0)")]
        public decimal? BatchId { get; set; }
        [Column("Exam_method")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ExamMethod { get; set; }
        [Column("License_Fee", TypeName = "money")]
        public decimal? LicenseFee { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("PIC_Name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PicName { get; set; }
        [Column("Aprroved_By")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AprrovedBy { get; set; }
        [Column("Aprroved_date", TypeName = "datetime")]
        public DateTime? AprrovedDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Total { get; set; }
        [Column("Bukti_Bayar")]
        [StringLength(255)]
        [Unicode(false)]
        public string? BuktiBayar { get; set; }
        [Column("Bukti_Byr2")]
        [StringLength(255)]
        [Unicode(false)]
        public string? BuktiByr2 { get; set; }
        [Column("Bukti_Byr3")]
        [StringLength(255)]
        [Unicode(false)]
        public string? BuktiByr3 { get; set; }
        [Column("Create_Date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("cabang")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cabang { get; set; }
    }
}
