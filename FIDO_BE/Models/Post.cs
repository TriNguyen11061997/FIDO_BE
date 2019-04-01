namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Post
    {
        [Key]
        public int PostID { get; set; }

        [StringLength(50)]
        public string AAStatus { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        [StringLength(50)]
        public string AACreatedDate { get; set; }

        [StringLength(50)]
        public string AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string PostNo { get; set; }

        [StringLength(1024)]
        public string PostContent { get; set; }

        public int? FK_EmployeeID { get; set; }
        [ForeignKey("FK_EmployeeID")]
        public virtual Employee Employee { get; set; }



    }
}
