namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? ContactDate { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]

        [StringLength(500)]
        public string ContactContent { get; set; }

        [StringLength(50)]
        public string ContactStatus { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
