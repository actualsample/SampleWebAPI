using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("test")]
    public partial class Test
    {
        [Column("aa")]
        [StringLength(20)]
        public string? Aa { get; set; }
    }
}
