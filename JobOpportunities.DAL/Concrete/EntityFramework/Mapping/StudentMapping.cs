using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
    class StudentMapping : EntityTypeConfiguration<Student>
	{
		public StudentMapping()
		{
            Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Student");
            });

            HasKey(a => a.ID);

            HasMany(a => a.JobExperiences)
                .WithRequired(a => a.Student)
                .HasForeignKey(a => a.StudentID);

            HasMany(a => a.Student_JobOpportunities)
                .WithRequired(a => a.Student)
                .HasForeignKey(a => a.StudentID);

            HasMany(a => a.Student_Languages)
              .WithRequired(a => a.Student)
              .HasForeignKey(a => a.StudentID);


            HasMany(c => c.Cities)
                .WithMany(s => s.Students)
                .Map(cs => {
                    cs.MapLeftKey("ID");
                    cs.MapRightKey("CityID");
                    cs.ToTable("Student_City");
                });


            HasMany(sk => sk.Skills)
                .WithMany(s => s.Students)
                .Map(sks => {
                    sks.MapLeftKey("ID");
                    sks.MapRightKey("SkillID");
                    sks.ToTable("Student_Skill");
                });

            Property(a => a.Name).HasMaxLength(40);
            Property(a => a.Surname).HasMaxLength(40);
            Property(a => a.TCKN).HasMaxLength(11);
            Property(a => a.CvLink).HasMaxLength(250);
            Property(a => a.StateDescription).HasMaxLength(250);
           
            

           
        }
	}
}
