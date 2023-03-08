using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_jenis_kelamin")]
    public partial class MstJenisKelamin
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("kode_jenis_kelamin")]
        [StringLength(10)]
        public string? KodeJenisKelamin { get; set; }
        [Column("nama_jenis_kelamin")]
        [StringLength(20)]
        public string? NamaJenisKelamin { get; set; }
    }
}
