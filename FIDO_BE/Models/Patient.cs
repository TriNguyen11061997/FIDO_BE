namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Patient
    {
        public Patient()
        {
        }
        [Key]
        public int PatientID { get; set; }

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
        public string PatientNo { get; set; }

        [StringLength(150)]
        public string PatientName { get; set; }

        [StringLength(50)]
        public string PatientGender { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime PatientBirthDay { get; set; }

        [StringLength(255)]
        public string PatientDesc { get; set; }

        public string PatientPicture { get; set; }

        [StringLength(50)]
        public string PatientIDNumber { get; set; }

        [StringLength(150)]
        public string PatientIDNumberPlace { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? PatientIDNumberDate { get; set; }

        [StringLength(50)]
        public string PatientTel { get; set; }

        [StringLength(50)]
        public string PatientEmail { get; set; }

        public int? FK_AddressID { get; set; }
        [ForeignKey("FK_AddressID")]
        public virtual Address Address { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }


        public virtual ICollection<ForumDetail> ForumDetails { get; set; }


        public virtual ICollection<Forum> Forums { get; set; }

        public virtual ICollection<Location> Locations { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
