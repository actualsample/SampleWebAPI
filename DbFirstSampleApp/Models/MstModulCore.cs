using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_modul_core")]
    public partial class MstModulCore
    {
        [Key]
        [Column("id_modul_core")]
        public int IdModulCore { get; set; }
        [Column("no_urut")]
        public int? NoUrut { get; set; }
        [Column("nama_modul")]
        [Unicode(false)]
        public string? NamaModul { get; set; }
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
    }
}
