using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
    public class JobOpportunityViewModel
    {
        public Guid JobOpportunityID { get; set; }
        public string CompanyName { get; set; }
        public string StudentID { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string CompanyLink { get; set; }
        public string Detail { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}