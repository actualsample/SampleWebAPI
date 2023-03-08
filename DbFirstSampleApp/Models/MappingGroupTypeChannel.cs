using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mapping_group_type_channel")]
    public partial class MappingGroupTypeChannel
    {
        [Column("nama_group")]
        [StringLength(10)]
        public string? NamaGroup { get; set; }
        [Column("type_data")]
        [StringLength(10)]
        public string? TypeData { get; set; }
    }
}
