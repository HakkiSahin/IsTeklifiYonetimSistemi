using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class Student_JobOpportunityMapping : EntityTypeConfiguration<Student_JobOpportunity>
	{
		public Student_JobOpportunityMapping()
		{
            //HasKey(a => a.StudentID);
            //HasKey(a => a.JobOpportunityID);

            Property(a => a.Description).HasMaxLength(250);

		}
	}
}
