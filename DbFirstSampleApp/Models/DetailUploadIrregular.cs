using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_upload_irregular")]
    public partial class DetailUploadIrregular
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mst_irregular")]
        public int? IdMstIrregular { get; set; }
        [Column("no")]
        public int? No { get; set; }
        [Column("agent_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgentName { get; set; }
        [Column("agent_code")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgentCode { get; set; }
        [Column("no_hp")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoHp { get; set; }
        [Column("no_ktp")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoKtp { get; set; }
        [Column("id_mobis")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdMobis { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("tgl_ujian", TypeName = "date")]
        public DateTime? TglUjian { get; set; }
        [Column("session_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SessionUjian { get; set; }
        [Column("create_by")]
        [StringLength(30)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("update_by")]
        [StringLength(30)]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("status_data")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StatusData { get; set; }
        [Column("ket")]
        [Unicode(false)]
        public string? Ket { get; set; }
    }
}
