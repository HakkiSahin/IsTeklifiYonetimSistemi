using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
    public interface IJobOpportunityService:IServiceBase<JobOpportunity>
    {
		JobOpportunity GetJobOpportunityByID(Guid jobOpportunity);

        bool DeleteJobOpportunityByID(Guid jobOpportunity);

		
    }
}
