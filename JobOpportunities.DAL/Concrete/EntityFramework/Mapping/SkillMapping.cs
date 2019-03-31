using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class SkillMapping : EntityTypeConfiguration<Skill>
	{
		public SkillMapping()
		{
            HasKey(a => a.SkillID);

            Property(a => a.SkillName).HasMaxLength(20);
           
        }
	}
}
