using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTransMateri
    {
        [Column("id_trans_materi")]
        public int IdTransMateri { get; set; }
        [Column("id_modul")]
        public int? IdModul { get; set; }
        [Column("id_materi")]
        public int? IdMateri { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("isi_materi")]
        [Unicode(false)]
        public string? IsiMateri { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("deskripsi")]
        [Unicode(false)]
        public string? Deskripsi { get; set; }
        [Column("header")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Header { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
    }
}
