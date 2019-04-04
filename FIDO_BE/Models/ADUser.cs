namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ADUser
    {
        [Key]
        public int ADUserID { get; set; }

        [StringLength(10)]
        public string AAStatus { get; set; }

        public virtual ADUserGroup ADUserGroup { get; set; }
        [ForeignKey("ADUserGroupID")]
        public int ADUserGroupID { get; set; }

        public int? FK_ReferenceID { get; set; }

        [StringLength(100)]
        public string ADUserName { get; set; }

        [StringLength(100)]
        public string ADPassword { get; set; }

        public bool? ADUserActiveCheck { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AACreatedDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(500)]
        public string ADUserResetToken { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? ADUserDate { get; set; }

    }
}
