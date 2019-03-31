using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
     class TeacherMapping : EntityTypeConfiguration<Teacher>
    {
        public TeacherMapping()
        {
            
            Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Teacher");
            });

            HasKey(a => a.ID);

            HasMany(a => a.Clans)
                .WithRequired(a => a.Teacher)
                .HasForeignKey(a => a.TeacherID);

            Property(a => a.Name).HasMaxLength(40);
            Property(a => a.Surname).HasMaxLength(40);
            Property(a => a.TCKN).HasMaxLength(11);
        }
    }
}
