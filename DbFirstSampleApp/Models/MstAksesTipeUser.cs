using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Keyless]
    [Table("mst_akses_tipe_user")]
    public partial class MstAksesTipeUser
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_tipe_user")]
        public int? IdTipeUser { get; set; }
        [Column("id_menu")]
        public int? IdMenu { get; set; }
        [Column("status")]
        public short? Status { get; set; }
    }
}
