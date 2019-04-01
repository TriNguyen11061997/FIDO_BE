namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ADUserGroup
    {
        public ADUserGroup()
        {
        }
        [Key]
        public int ADUserGroupID { get; set; }

        [StringLength(10)]
        public string AAStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string ADUserGroupName { get; set; }

        [StringLength(255)]
        public string ADUserGroupDesc { get; set; }

        public virtual ICollection<ADUser> ADUsers { get; set; }
    }
}
