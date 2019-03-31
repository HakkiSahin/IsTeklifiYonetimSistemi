using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
    class UserAccountMapping : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountMapping()
        {
            HasKey(a => a.UserAccountID);

            HasOptional(a => a.Student)
                 .WithRequired(a => a.UserAccount);

            HasOptional(a => a.Advisor)
                .WithRequired(a => a.UserAccount);

            Property(a => a.Mail).HasMaxLength(50);
            Property(a => a.Password).HasMaxLength(20);

            
        }
    }
}
