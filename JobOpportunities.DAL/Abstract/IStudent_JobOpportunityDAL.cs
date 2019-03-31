using JobOpportunities.Core.DataAccess;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Abstract
{
   public interface IStudent_JobOpportunityDAL :IEntityRepository<Student_JobOpportunity>
    {
    }
}
