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
        public DbSet<ADUserGroups> ADUserGroups { get; set; }
        public FIDOContext(DbContextOptions<FIDOContext> options)
            : base(options)
        {
        }


        void Seed(FIDOContext context)
        {
            {
                context.ADUserGroups.Add(new ADUserGroups
                {
                    ADUserGroupID = 1,
                    AAStatus = "Alive",
                    ADUserGroupDesc = "11",
                    ADUserGroupName = "",
                    Ngay = DateTime.Now
                    
                });
            }
        }
    }
}
