using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_tagihan_cpd")]
    public partial class DetailTagihanCpd
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_tagihan")]
        public int IdTagihan { get; set; }
        [Column("no")]
        public int? No { get; set; }
        [Column("item")]
        [Unicode(false)]
        public string? Item { get; set; }
        [Column("gross")]
        public double? Gross { get; set; }
        [Column("net")]
        public double? Net { get; set; }
        [Column("pajak")]
        public double? Pajak { get; set; }
        [Column("status")]
        [StringLength(10)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("cover_biaya")]
        public double? CoverBiaya { get; set; }
        [Column("nominal_transfer")]
        public double? NominalTransfer { get; set; }
        [Column("jenis_tagihan")]
        public int? JenisTagihan { get; set; }
        [Column("status_pengerjaan")]
        public short? StatusPengerjaan { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
    }
}
