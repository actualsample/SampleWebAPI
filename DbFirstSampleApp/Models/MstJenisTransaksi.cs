using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_jenis_transaksi")]
    public partial class MstJenisTransaksi
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nama_jenis_transaksi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisTransaksi { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
