using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_jenis_modul")]
    public partial class MstJenisModul
    {
        [Key]
        [Column("id_jenis_modul")]
        public int IdJenisModul { get; set; }
        [Column("nama_jenis_modul")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisModul { get; set; }
        [Column("point")]
        public int? Point { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
    }
}
