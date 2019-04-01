namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Rating
    {
        [Key]
        public int RatingID { get; set; }

        [StringLength(10)]
        public string RatingDate { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]

        public int? RatingIndex { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
