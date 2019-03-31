using JobOpportunities.BLL.Abstract;
using JobOpportunities.DAL.Abstract;
using JobOpportunities.DAL.Concrete.EntityFramework.DAL;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Concrete
{
    public class JobOpportunityBLL : IJobOpportunityService
    {
        EFJobOpportunityDAL _jobOpportunityDAL;

        public JobOpportunityBLL()
        {
            _jobOpportunityDAL = new EFJobOpportunityDAL();
        }
        public bool Delete(JobOpportunity jobOpportunity)
        {
            return _jobOpportunityDAL.Remove(jobOpportunity)>0;
        }

        public bool DeleteByID(int jobOpportunityID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJobOpportunityByID(Guid jobOpportunityID)
        {
            JobOpportunity jobOpportunity = _jobOpportunityDAL.Get(a => a.JobOpportunityID == jobOpportunityID);
            return _jobOpportunityDAL.Remove(jobOpportunity) > 0;
        }

        public JobOpportunity Get (Guid entityID)
        {
			return _jobOpportunityDAL.Get(a => a.JobOpportunityID == entityID);
		}

		public JobOpportunity Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<JobOpportunity> GetAll()
        {
            return _jobOpportunityDAL.GetAll();
        }

        public JobOpportunity GetJobOpportunityByID(Guid jobOpportunityID)
        {
            return _jobOpportunityDAL.Get(a => a.JobOpportunityID == jobOpportunityID);
        }

        public bool Insert(JobOpportunity jobOpportunity)
        {
            jobOpportunity.JobOpportunityID = Guid.NewGuid();
            return _jobOpportunityDAL.Add(jobOpportunity) > 0;
        }

        public bool Update(JobOpportunity jobOpportunity)
        {
            return _jobOpportunityDAL.Update(jobOpportunity) > 0;
        }
    }
}
