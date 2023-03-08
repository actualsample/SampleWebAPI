using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("Query")]
    public partial class Query
    {
        [Column("id_batch_inv")]
        public int IdBatchInv { get; set; }
        [Column("no_inv_aaji")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoInvAaji { get; set; }
        [Column("nama_jenis_tagihan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTagihan { get; set; }
        [Column("tgl_inv_aaji")]
        [Precision(3)]
        public DateTime? TglInvAaji { get; set; }
        [Column("nominal_inv")]
        public double? NominalInv { get; set; }
        [Column("status_pdc")]
        public short? StatusPdc { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Dicover { get; set; } = null!;
        [Column("id_batch_pdc")]
        public int IdBatchPdc { get; set; }
    }
}
