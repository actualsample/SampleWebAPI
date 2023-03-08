using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("detail_upload_proses")]
    public partial class DetailUploadProse
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mst_proses")]
        public int? IdMstProses { get; set; }
        [Column("agent_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgentName { get; set; }
        [Column("agent_code")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgentCode { get; set; }
        [Column("user_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("digital_key")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DigitalKey { get; set; }
        [Column("home_city")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HomeCity { get; set; }
        [Column("product_type")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ProductType { get; set; }
        [Column("exam_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ExamStatus { get; set; }
        [Column("idupd")]
        public int? Idupd { get; set; }
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
    }
}
