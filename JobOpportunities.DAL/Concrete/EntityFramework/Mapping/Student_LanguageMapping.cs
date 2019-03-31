using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class Student_LanguageMapping : EntityTypeConfiguration<Student_Language>
	{
		public Student_LanguageMapping()
		{
            //HasKey(a => a.StudentID);
            //HasKey(a => a.LanguageID);
		}
	}
}
