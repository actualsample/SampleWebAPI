using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("transaksi_email")]
    public partial class TransaksiEmail
    {
        [Key]
        [Column("id_email")]
        public long IdEmail { get; set; }
        [Column("recipient")]
        public string? Recipient { get; set; }
        [Column("subject")]
        public string? Subject { get; set; }
        [Column("content")]
        public string? Content { get; set; }
        [Column("flag_send")]
        public int? FlagSend { get; set; }
        [Column("date_send")]
        public DateTime? DateSend { get; set; }
    }
}
