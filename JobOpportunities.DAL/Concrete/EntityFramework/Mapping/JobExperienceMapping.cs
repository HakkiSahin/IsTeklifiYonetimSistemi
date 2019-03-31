using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class JobExperienceMapping : EntityTypeConfiguration<JobExperience>
	{
		public JobExperienceMapping()
		{
            HasKey(a => a.JobExperienceID);
            Property(a => a.CompanyName).HasMaxLength(40);
            Property(a => a.Positon).HasMaxLength(30);
		}

	}
}
