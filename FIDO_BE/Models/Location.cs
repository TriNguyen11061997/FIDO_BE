namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Location")]
    public partial class Location
    {
        public int LocationID { get; set; }

        [StringLength(50)]
        public string LocationLongitude { get; set; }

        [StringLength(50)]
        public string LocationLatitude { get; set; }

        public int? FK_DoctorID { get; set; }
        [ForeignKey("FK_DoctorID")]

        public int? FK_PatientID { get; set; }
        [ForeignKey("FK_PatientID")]

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
