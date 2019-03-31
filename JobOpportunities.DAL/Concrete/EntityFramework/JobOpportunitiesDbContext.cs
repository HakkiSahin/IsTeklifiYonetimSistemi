using JobOpportunities.DAL.Concrete.EntityFramework.Mapping;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework
{
	public class JobOpportunitiesDbContext : DbContext
	{
		public JobOpportunitiesDbContext()
			:base("Server=.; DataBase=JobOppurtunities;Trusted_Connection=true")
		{
			Database.SetInitializer(new JobOpportunitiesDbInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.Configurations.Add(new AdvisorMapping());
            modelBuilder.Configurations.Add(new CityMapping());
            modelBuilder.Configurations.Add(new ClanMapping());
            modelBuilder.Configurations.Add(new JobExperienceMapping());
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new JobOpportunityMapping());
            modelBuilder.Configurations.Add(new LanguageMapping());
            modelBuilder.Configurations.Add(new RoleMapping());
            modelBuilder.Configurations.Add(new Student_JobOpportunityMapping());
            //modelBuilder.Configurations.Add(new Student_LanguageMapping());
            modelBuilder.Configurations.Add(new TeacherMapping());
            modelBuilder.Configurations.Add(new UserAccountMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public DbSet<City> Cities { get; set; }
		public DbSet<Contract> Contracts { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Clan> Clans { get; set; }
		public DbSet<JobExperience> JobExperiences { get; set; }
		public DbSet<JobOpportunity> JobOpportunities { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<Person> People { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Student_JobOpportunity> Student_JobOpportunities { get; set; }
		public DbSet<Student_Language> Student_Languages { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        

    }
}
