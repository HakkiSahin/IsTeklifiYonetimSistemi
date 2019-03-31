using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
  public  interface IStudent_JobOpportunityService :IServiceBase<Student_JobOpportunity>
    {

       List<Student_JobOpportunity> GetStudent_JobOpportunityByGuidID(Guid jobOpportunityID);
	   List<Student_JobOpportunity> GetStudent_JobOpportunityByStudentID(int StudentID);


	}
}
