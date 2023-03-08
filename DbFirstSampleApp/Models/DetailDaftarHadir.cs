using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_daftar_hadir")]
    public partial class DetailDaftarHadir
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("batch_id")]
        public int? BatchId { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
    }
}
