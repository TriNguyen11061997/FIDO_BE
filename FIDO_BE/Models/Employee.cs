namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Employee
    {
        public Employee()
        {

        }
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(10)]
        public string AAStatus { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AACreatedDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AAUpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeNo { get; set; }

        [StringLength(150)]
        public string EmployeeName { get; set; }

        [StringLength(50)]
        public string EmployeeGender { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeBirthDay { get; set; }

        [StringLength(255)]
        public string EmployeeDesc { get; set; }

        public string EmployeePicture { get; set; }

        [StringLength(50)]
        public string EmployeeIDNumber { get; set; }

        [StringLength(150)]
        public string EmployeeIDNumberPlace { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeIDNumberDate { get; set; }

        [StringLength(50)]
        public string EmployeePassportNo { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeePassportDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeePassportPlace { get; set; }

        [StringLength(50)]
        public string EmployeeTaxNumber { get; set; }

        public bool? EmployeeActiveCheck { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeStartWorkingDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeEndWorkingDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeStartWorkingTime { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EmployeeEndWorkingTime { get; set; }

        [StringLength(50)]
        public string EmployeeTel1 { get; set; }

        [StringLength(50)]
        public string EmployeeTel2 { get; set; }

        [StringLength(50)]
        public string EmployeeEmail1 { get; set; }

        [StringLength(50)]
        public string EmployeePassword1 { get; set; }

        [StringLength(50)]
        public string EmployeeEmail2 { get; set; }

        [StringLength(50)]
        public string EmployeeFax { get; set; }

        public int? FK_AddressID { get; set; }
        [ForeignKey("FK_AddressID")]
        public virtual Address Address { get; set; }

        public virtual ICollection<Certificate> Certificates { get; set; }


        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
