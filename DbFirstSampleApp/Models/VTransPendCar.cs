using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    public partial class VTransPendCar
    {
        [Column("kode_agent")]
        [StringLength(10)]
        [Unicode(false)]
        public string? KodeAgent { get; set; }
        [Column("nama_agent")]
        [Unicode(false)]
        public string? NamaAgent { get; set; }
        [Column("item")]
        [Unicode(false)]
        public string? Item { get; set; }
        [Column("gross")]
        public double? Gross { get; set; }
        [Column("net")]
        public double? Net { get; set; }
        [Column("pajak")]
        public double? Pajak { get; set; }
        [Column("id_detail_tagihan")]
        public int? IdDetailTagihan { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
