using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIDO_BE.Models
{
    public class ADUserGroups
    {
        public ADUserGroups()
        {
        }
        [Key]
        public int ADUserGroupID { get; set; }

        public string AAStatus { get; set; }

        public string ADUserGroupName { get; set; }

        public string ADUserGroupDesc { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Ngay { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Ngay1 { get; set; }

    }
}
