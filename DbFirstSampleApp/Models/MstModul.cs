using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_modul")]
    public partial class MstModul
    {
        [Key]
        [Column("id_modul")]
        public int IdModul { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
        [Column("jenis_modul")]
        public int? JenisModul { get; set; }
        [Column("status_flag")]
        public short? StatusFlag { get; set; }
        [Column("create_by")]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("jml_soal")]
        public int? JmlSoal { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
    }
}
