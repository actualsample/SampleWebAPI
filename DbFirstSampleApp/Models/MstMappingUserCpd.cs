using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_mapping_user_cpd")]
    public partial class MstMappingUserCpd
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("no_lisensi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NoLisensi { get; set; }
        [Column("user_id")]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("id_peserta")]
        public int? IdPeserta { get; set; }
    }
}
