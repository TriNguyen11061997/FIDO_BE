using FIDO_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIDO_BE.Data
{
    public class FIDOContext : DbContext
    {
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ADUserGroup> ADUserGroups { get; set; }
        public virtual DbSet<ADUser> ADUsers { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ForumDetail> ForumDetails { get; set; }
        public virtual DbSet<Forum> Forums { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<GENumbering> GENumberings { get; set; }
        public FIDOContext(DbContextOptions<FIDOContext> options)
            : base(options)
        {
        }
    }
}
