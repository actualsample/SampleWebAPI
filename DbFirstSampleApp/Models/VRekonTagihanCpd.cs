using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VRekonTagihanCpd
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_mutasi")]
        public int? IdMutasi { get; set; }
        [Column("id_tagihan")]
        public int? IdTagihan { get; set; }
        [Column("mutasi_id_fms")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MutasiIdFms { get; set; }
        [Column("paid_date", TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
    }
}
