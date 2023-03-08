using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_prodtype")]
    public partial class MstProdtype
    {
        [Key]
        [Column("IDTYPE")]
        [StringLength(10)]
        [Unicode(false)]
        public string Idtype { get; set; } = null!;
        [Column("Product_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProductType { get; set; }
    }
}
