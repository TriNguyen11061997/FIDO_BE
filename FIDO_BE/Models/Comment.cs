namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Comment
    {
        public int CommentID { get; set; }

        [StringLength(500)]
        public string CommentContent { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]

        [StringLength(10)]
        public string CommentStatus { get; set; }

        [StringLength(500)]
        public string CommentReportDesc { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? CommentDate { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
