using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_status")]
    public partial class MstStatus
    {
        [Key]
        [Column("StsID")]
        public int StsId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Formgroup { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Keterangan { get; set; }
    }
}
