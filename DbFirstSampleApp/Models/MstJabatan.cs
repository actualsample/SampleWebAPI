using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_jabatan")]
    public partial class MstJabatan
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("kode_jabatan")]
        [StringLength(10)]
        public string? KodeJabatan { get; set; }
        [Column("nama_jabatan")]
        [StringLength(10)]
        public string? NamaJabatan { get; set; }
    }
}
