using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("test1")]
    public partial class Test1
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("photo", TypeName = "image")]
        public byte[]? Photo { get; set; }
    }
}
