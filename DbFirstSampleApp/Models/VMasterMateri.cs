using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VMasterMateri
    {
        [Column("id_materi")]
        public int IdMateri { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("isi_materi")]
        [Unicode(false)]
        public string? IsiMateri { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("deskripsi")]
        [Unicode(false)]
        public string? Deskripsi { get; set; }
        [Column("header")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Header { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("nama_jenis_modul")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaJenisModul { get; set; }
        [Column("status")]
        [StringLength(11)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
