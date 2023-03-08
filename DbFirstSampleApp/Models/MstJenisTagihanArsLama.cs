using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_jenis_tagihan_ars_lama")]
    public partial class MstJenisTagihanArsLama
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nama_jenis_tagihan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTagihan { get; set; }
        [Column("status_pajak")]
        public short? StatusPajak { get; set; }
    }
}
