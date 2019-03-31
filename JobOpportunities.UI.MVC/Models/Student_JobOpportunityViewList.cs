using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
    public class Student_JobOpportunityViewList
    {
        public Guid JobOpportunityID { get; set; }
        public List<Student_JobOpportunity> Check { get; set; }
        public List<Student_JobOpportunity> Notcheck { get; set; }
        public List<Student_JobOpportunity> BoolNull { get; set; }
    }
}