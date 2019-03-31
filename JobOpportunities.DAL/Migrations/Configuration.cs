namespace JobOpportunities.DAL.Migrations
{
	using JobOpportunities.Entities;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JobOpportunities.DAL.Concrete.EntityFramework.JobOpportunitiesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(JobOpportunities.DAL.Concrete.EntityFramework.JobOpportunitiesDbContext context)
        {
			//Language Tablosu
			IList<Language> defaultLanguages = new List<Language>();
			defaultLanguages.Add(new Language() { LanguageName = "Ýngilizce" });
			defaultLanguages.Add(new Language() { LanguageName = "Almanca" });
			defaultLanguages.Add(new Language() { LanguageName = "Fransýzca" });
			context.Languages.AddRange(defaultLanguages);

            //City Table
            IList<City> defaultCity = new List<City>();
            defaultCity.Add(new City() { CityName="Ýstanbul" });
            defaultCity.Add(new City() { CityName = "Ankara" });
            defaultCity.Add(new City() { CityName = "Ýzmir" });
            context.Cities.AddRange(defaultCity);

            //Role Tablosu
            IList<Role> defaultRoles = new List<Role>();
			defaultRoles.Add(new Role() { RoleName="Admin" });
			defaultRoles.Add(new Role() { RoleName = "Advisor" });
			defaultRoles.Add(new Role() { RoleName = "Student" });
			context.Roles.AddRange(defaultRoles);

			//Contract Tablosu
			IList<Contract> defaultContracts = new List<Contract>();
			defaultContracts.Add(new Contract() { ContractName = "NBUY 1" });
			defaultContracts.Add(new Contract() { ContractName = "NBUY 2" });
			defaultContracts.Add(new Contract() { ContractName = "NBUY 3" });
			defaultContracts.Add(new Contract() { ContractName = "NBUY 4" });
			context.Contracts.AddRange(defaultContracts);

			//Department Tablosu
			IList<Department> defaultDepartments = new List<Department>();
			defaultDepartments.Add(new Department() { DepartmentName = "Yazýlým" });
			defaultDepartments.Add(new Department() { DepartmentName = "Veri Analizi" });
			defaultDepartments.Add(new Department() { DepartmentName = "Sistem" });			
			context.Departments.AddRange(defaultDepartments);

            //User Table
            IList<UserAccount> defaultUser = new List<UserAccount>();
            defaultUser.Add(new UserAccount() { Mail="student" , Password="1234",RoleID= 3});
            defaultUser.Add(new UserAccount() { Mail = "student1", Password = "1234", RoleID = 3 });
            defaultUser.Add(new UserAccount() { Mail = "advisor", Password = "1234", RoleID = 2 });
            context.UserAccounts.AddRange(defaultUser);

            //Teacher TAble

            //IList<Teacher> defaultTeacher = new List<Teacher>();
            //defaultTeacher.Add(new Teacher() { ID=1,Name="Bahar",Surname="Yalkýn",TCKN="11111111"});
            //defaultTeacher.Add(new Teacher() { ID = 2, Name = "Nihan", Surname = "Teyze", TCKN = "99999999" });
            //defaultTeacher.Add(new Teacher() { ID = 3, Name = "Akýn", Surname = "Kara", TCKN = "22222222" });
            //context..AddRange(defaultTeacher);

            //Clan Table
            //IList<Clan> defaultClan = new List<Clan>();
            //defaultClan.Add(new Clan() { ContractID= 4 , TeacherID = 1 , DepartmentID = 1 , PortalNo= "720546", GroupClass = "ERP 103 Sabah" , Term="26 Kasým 2018"});
            //defaultClan.Add(new Clan() { ContractID = 3, TeacherID = 2, DepartmentID = 2, PortalNo = "720000", GroupClass = "AAA 103 Öðle", Term = "26 Kasým 2017" });
            //context.Clans.AddRange(defaultClan);





            context.SaveChanges();
		}
    }
}
