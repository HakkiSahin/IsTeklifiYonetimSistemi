using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class LanguageMapping : EntityTypeConfiguration<Language>
	{
		public LanguageMapping()
		{
            HasKey(a => a.LanguageID);

            HasMany(a => a.Student_Languages)
              .WithRequired(a => a.Language)
              .HasForeignKey(a => a.LanguageID);

            Property(a => a.LanguageName).HasMaxLength(30);
        }
	}
}
