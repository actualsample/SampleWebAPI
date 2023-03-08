using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_office_city")]
    public partial class MstOfficeCity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("office_city")]
        [StringLength(50)]
        [Unicode(false)]
        public string? OfficeCity { get; set; }
    }
}
