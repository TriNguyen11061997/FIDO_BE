namespace FIDO_BE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Address
    {
        public Address()
        {
        }
        [Key]
        public int AddressID { get; set; }

        public int? ContactAddressStreet { get; set; }

        public int? ContactAddressLine { get; set; }

        public int? ContactAddressCity { get; set; }

        public int? ContactAddressPostalCode { get; set; }

        public int? ContactAddressStateProvince { get; set; }

        public int? ContactAddressZipCode { get; set; }

        public int? ContactAddressCountry { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
