namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Certificate
    {
        [Key]
        public int CertificateID { get; set; }

        [StringLength(50)]
        public string CertificateStatus { get; set; }

        public string CertificateDesc { get; set; }

        public string CertificatePicture1 { get; set; }


        public string CertificatePicture2 { get; set; }


        public string CertificatePicture3 { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? CertificateDate { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]
        public virtual Doctor Doctor { get; set; }

        public int? FK_EmployeeID { get; set; }
        [ForeignKey("FK_EmployeeID")]
        public virtual Employee  Employee { get; set; }

    }
}
