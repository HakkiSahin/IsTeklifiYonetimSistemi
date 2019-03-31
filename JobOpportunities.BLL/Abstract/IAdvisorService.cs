using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
    public interface IAdvisorService:IServiceBase<Advisor>
    {
		Advisor GetByID(int advisorID);
    }
}
