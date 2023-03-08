using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("detail_batch_inv")]
    public partial class DetailBatchInv
    {
        [Column("id_detail")]
        public int IdDetail { get; set; }
        [Column("id_batch_inv")]
        public int? IdBatchInv { get; set; }
        [Column("id_tagihan")]
        public int? IdTagihan { get; set; }
        [Column("id_detail_tagihan")]
        public int? IdDetailTagihan { get; set; }
    }
}
