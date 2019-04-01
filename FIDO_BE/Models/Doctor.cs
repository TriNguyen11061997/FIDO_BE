namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Doctor
    {
        public Doctor()
        {
        }
        [Key]
        public int DoctorID { get; set; }

        [StringLength(50)]
        public string AAStatus { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AACreatedDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string DoctorNo { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string DoctorAvatar { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? DoctorBirthDay { get; set; }

        [StringLength(50)]
        public string DoctorDesc { get; set; }

        [StringLength(10)]
        public string DoctorGender { get; set; }

        [StringLength(10)]
        public string DoctorStatus { get; set; }

        [StringLength(50)]
        public string DoctorIDNumber { get; set; }

        [StringLength(50)]
        public string DoctorIDNumberPlace { get; set; }

        [StringLength(50)]
        public string DoctorIDNumberDate { get; set; }

        [StringLength(50)]
        public string DoctorPassportNo { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? DoctorPassportDate { get; set; }

        [StringLength(50)]
        public string DoctorPassportPlace { get; set; }

        [StringLength(50)]
        public string DoctorPhone1 { get; set; }

        [StringLength(50)]
        public string DoctorPhone2 { get; set; }

        [StringLength(50)]
        public string DoctorEmail { get; set; }

        public int? FK_EmployeeID { get; set; }
        [ForeignKey("FK_EmployeeID")]

        [StringLength(10)]
        public string DoctorSpecialist { get; set; }

        [StringLength(10)]
        public string HospitalName { get; set; }

        [StringLength(10)]
        public string EmployeeName { get; set; }

        public int? FK_AddressID { get; set; }
        [ForeignKey("FK_AddressID")]
        public virtual Address Address { get; set; }


        public virtual ICollection<Certificate> Certificates { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }


        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual Employee Employee { get; set; }


        public virtual ICollection<Forum> Forums { get; set; }


        public virtual ICollection<ForumDetail> ForumDetails { get; set; }

  
        public virtual ICollection<Location> Locations { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
