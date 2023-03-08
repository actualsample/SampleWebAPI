using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("tr_log_proses_batch")]
    public partial class TrLogProsesBatch
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("idupd")]
        public int? Idupd { get; set; }
        [Column("uploadid")]
        public int? Uploadid { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
