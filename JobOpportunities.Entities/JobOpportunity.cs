using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class JobOpportunity : IEntity
	{
        public JobOpportunity()
        {
            Student_JobOpportunities = new HashSet<Student_JobOpportunity>();
        }
        public Guid JobOpportunityID { get; set; }
        public string Department { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string CompanyLink { get; set; }
        public string Detail { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation Property

        public virtual ICollection<Student_JobOpportunity> Student_JobOpportunities { get; set; }

    }
}
