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
    public class JobExperienceBLL : IJobExperienceService
    {
        EFJobExperienceDAL _jobExperienceDAL;

        public JobExperienceBLL()
        {
            _jobExperienceDAL = new EFJobExperienceDAL() ;
        }
        public bool Delete(JobExperience jobExperience)
        {
            return _jobExperienceDAL.Remove(jobExperience)>0;
        }

        public bool DeleteByID(int jobExperienceID)
        {
            JobExperience jobExperience = _jobExperienceDAL.Get(a => a.JobExperienceID == jobExperienceID);
            return _jobExperienceDAL.Remove(jobExperience)>0;
        }

        public JobExperience Get(int jobExperienceID)
        {
            return _jobExperienceDAL.Get(a => a.JobExperienceID == jobExperienceID);
        }

        public ICollection<JobExperience> GetAll()
        {
            return _jobExperienceDAL.GetAll();
        }

        public bool Insert(JobExperience jobExperience)
        {
            return _jobExperienceDAL.Add(jobExperience) > 0;
        }

        public bool Update(JobExperience jobExperience)
        {
            return _jobExperienceDAL.Update(jobExperience) > 0;
        }
    }
}
