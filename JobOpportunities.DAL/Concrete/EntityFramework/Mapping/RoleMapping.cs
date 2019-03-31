using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
    class RoleMapping :  EntityTypeConfiguration<Role>
    {
        public RoleMapping()
        {
            HasKey(a => a.RoleID);

            HasMany(a => a.UserAccounts)
                .WithRequired(a => a.Role)
                .HasForeignKey(a => a.RoleID);

            Property(a => a.RoleName).HasMaxLength(10);
        }
    }
}
