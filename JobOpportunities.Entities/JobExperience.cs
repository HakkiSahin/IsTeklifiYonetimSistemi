using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class JobExperience : IEntity
	{
        public int JobExperienceID { get; set; }
        public int StudentID { get; set; }
        public string CompanyName { get; set; }
        public string Positon { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation Property
        public virtual Student Student { get; set; }
    }
}
