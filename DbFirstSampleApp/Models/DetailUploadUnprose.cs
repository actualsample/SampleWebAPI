using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_upload_unproses")]
    public partial class DetailUploadUnprose
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mst_unproses")]
        public int? IdMstUnproses { get; set; }
        [Column("agent_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgentName { get; set; }
        [Column("agent_code")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgentCode { get; set; }
        [Column("home_city")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HomeCity { get; set; }
        [Column("reason")]
        [Unicode(false)]
        public string? Reason { get; set; }
        [Column("no_ktp")]
        [StringLength(20)]
        [Unicode(false)]
        public string? NoKtp { get; set; }
        [Column("tgl_lahir", TypeName = "date")]
        public DateTime? TglLahir { get; set; }
        [Column("action")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Action { get; set; }
        [Column("create_by")]
        [StringLength(30)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
