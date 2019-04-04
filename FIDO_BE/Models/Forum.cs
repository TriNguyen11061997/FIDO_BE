namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Forums")]
    public partial class Forum
    {

        public Forum()
        {
        }
        [Key]
        public int ForumID { get; set; }

        [StringLength(500)]
        public string ForumContent { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? ForumDate { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]
        public virtual Doctor Doctor { get; set; }

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]
        public virtual Patient Patient { get; set; }

        public virtual ICollection<ForumDetail> ForumDetails { get; set; }

       
    }
}
