namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class GENumbering
    {
        public int GENumberingID { get; set; }

        [StringLength(50)]
        public string AAStatus { get; set; }

        [StringLength(50)]
        public string GENumberingName { get; set; }

        public int? GENumberingPrefix { get; set; }

        public int? GENumberingLength { get; set; }

        public int? GENumberingStart { get; set; }

        [StringLength(50)]
        public string GENumberingDesc { get; set; }

        [StringLength(50)]
        public string GETableName { get; set; }
    }
}
