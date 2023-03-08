using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_status_perkawinan")]
    public partial class MstStatusPerkawinan
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("kode_status")]
        [StringLength(10)]
        public string? KodeStatus { get; set; }
        [Column("nama_status")]
        [StringLength(20)]
        public string? NamaStatus { get; set; }
    }
}
