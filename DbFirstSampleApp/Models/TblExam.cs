using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirstSampleApp.Models
{
    [Table("Tbl_Exam")]
    public partial class TblExam
    {
        [Key]
        [Column("UID")]
        public int Uid { get; set; }
        [Column("Schedule_Type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ScheduleType { get; set; }
        [Column("Exam_Method")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ExamMethod { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? City { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Venue { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Tanggal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Session { get; set; }
        [Column("Total_participant")]
        public int? TotalParticipant { get; set; }
        [Column("Schedule_Status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ScheduleStatus { get; set; }
        [Column("Last_registration", TypeName = "datetime")]
        public DateTime? LastRegistration { get; set; }
    }
}
