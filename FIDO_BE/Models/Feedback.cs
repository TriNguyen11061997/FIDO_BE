namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Feedback
    {
        public int FeedbackID { get; set; }

        [StringLength(500)]
        public string FeedbackDesc { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? FeedbackDate { get; set; }

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]
        public virtual Patient Patient { get; set; }
    }
}
