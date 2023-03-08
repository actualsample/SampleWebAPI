using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_status_cpd")]
    public partial class MstStatusCpd
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nama_status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NamaStatus { get; set; }
        [Column("form")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Form { get; set; }
    }
}
