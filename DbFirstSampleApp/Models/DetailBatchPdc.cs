using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("detail_batch_pdc")]
    public partial class DetailBatchPdc
    {
        [Column("id_detail_pdc")]
        public int IdDetailPdc { get; set; }
        [Column("id_batch_pdc")]
        public int? IdBatchPdc { get; set; }
        [Column("id_batch_inv")]
        public int? IdBatchInv { get; set; }
    }
}
