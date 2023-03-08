using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("m_Tanggal_Ujian")]
    public partial class MTanggalUjian
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Hari { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Tanggal { get; set; }
        [Column("Batas_Tanggal", TypeName = "datetime")]
        public DateTime? BatasTanggal { get; set; }
        [Column("Status_Aktif")]
        public int? StatusAktif { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Jenis { get; set; }
    }
}
