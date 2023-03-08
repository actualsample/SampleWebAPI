using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("trans_pend_car")]
    public partial class TransPendCar
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_detail_tagihan")]
        public int? IdDetailTagihan { get; set; }
    }
}
