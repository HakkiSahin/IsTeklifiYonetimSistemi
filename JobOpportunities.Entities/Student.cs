using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Student : Person,IEntity
    {
        public Student()
        {
            Cities = new HashSet<City>();
            JobExperiences = new HashSet<JobExperience>();
            Skills = new HashSet<Skill>();
            Student_Languages = new HashSet<Student_Language>();
            Student_JobOpportunities = new HashSet<Student_JobOpportunity>();
        }

		//Otomatik sayı olmayacak UserAccount sayfasına eklenecek oraya eklenen son UserAccountID buranın
		//ID si olacak
		
         
        
        public int ClanID { get; set; }
        public string CvLink { get; set; }
        public bool? IsActive { get; set; }
        public bool? MilitaryState { get; set; }
        public int? MinimumWage { get; set; }
        public string StateDescription { get; set; }
        public int? TotalExperience { get; set; }

		//Navigation Property

		public virtual UserAccount UserAccount { get; set; }
		public virtual Clan Clan { get; set; }
        public ICollection<Student_JobOpportunity> Student_JobOpportunities { get; set; }
        public ICollection<Student_Language> Student_Languages { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<JobExperience> JobExperiences { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
