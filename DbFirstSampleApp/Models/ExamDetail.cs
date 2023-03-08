using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("exam_detail")]
    public partial class ExamDetail
    {
        [Key]
        [Column("EUID")]
        public int Euid { get; set; }
        [Column("UID")]
        public int? Uid { get; set; }
        [Column("Agen_code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgenCode { get; set; }
        [Column("Agent_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgentName { get; set; }
        [Column("Product_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProductType { get; set; }
        [Column("Agen_office_City")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgenOfficeCity { get; set; }
    }
}
