namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ForumDetail
    {
        public int ForumDetailID { get; set; }

        [StringLength(500)]
        public string ForumDetailContent { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? ForumDetailDate { get; set; }

        public int? FK_ForumID { get; set; }
        [ForeignKey("FK_ForumID")]
        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]

        public virtual Doctor Doctor { get; set; }

        public virtual Forum Forum { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
