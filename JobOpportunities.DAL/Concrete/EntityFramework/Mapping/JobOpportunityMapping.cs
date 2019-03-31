using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class JobOpportunityMapping : EntityTypeConfiguration<JobOpportunity>
	{
		public JobOpportunityMapping()
		{
            HasKey(a => a.JobOpportunityID);

            HasMany(a => a.Student_JobOpportunities)
                .WithRequired(a => a.JobOpportunity)
                .HasForeignKey(a => a.JobOpportunityID);

            Property(a => a.CompanyName).HasMaxLength(50);
            Property(a => a.Position).HasMaxLength(30);
            Property(a => a.Location).HasMaxLength(100);
            Property(a => a.CompanyLink).HasMaxLength(100);
            Property(a => a.Detail).HasMaxLength(500);
		}
	}
}
