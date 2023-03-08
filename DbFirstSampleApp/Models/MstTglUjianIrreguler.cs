using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("mst_tgl_ujian_irreguler")]
    public partial class MstTglUjianIrreguler
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hari")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Hari { get; set; }
        [Column("tgl_ujian", TypeName = "datetime")]
        public DateTime? TglUjian { get; set; }
        [Column("tgl_batas", TypeName = "datetime")]
        public DateTime? TglBatas { get; set; }
        [Column("kota_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KotaUjian { get; set; }
        [Column("lokasi_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LokasiUjian { get; set; }
        [Column("kuota")]
        public int? Kuota { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreateBy { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("update_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdateBy { get; set; }
        [Column("jenis_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? JenisUjian { get; set; }
        [Column("metode_ujian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MetodeUjian { get; set; }
        [Column("biaya")]
        public double? Biaya { get; set; }
        [Column("id_mst_tarifujian")]
        public int? IdMstTarifujian { get; set; }
    }
}
