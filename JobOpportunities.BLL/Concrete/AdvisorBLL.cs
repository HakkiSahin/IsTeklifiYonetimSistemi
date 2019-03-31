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
    public class AdvisorBLL : IAdvisorService
    {
       
        EFAdvisorDAL _advisorDAL;

        public AdvisorBLL()
        {
            _advisorDAL = new EFAdvisorDAL();
        }

        public bool Delete(Advisor advisor)
        {
            return _advisorDAL.Remove(advisor) > 0;
        }

        public bool DeleteByID(int advisorID)
        {
            Advisor advisor = _advisorDAL.Get(a => a.ID == advisorID);
            return _advisorDAL.Remove(advisor) > 0;
        }

        public Advisor Get(int advisorID)
        {
            return _advisorDAL.Get(a => a.ID == advisorID);
        }

        public ICollection<Advisor> GetAll()
        {
            return _advisorDAL.GetAll();
        }

        public Advisor GetByID(int advisorID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Advisor advisor)
        {
            return _advisorDAL.Add(advisor)>0;
        }

        public bool Update(Advisor advisor)
        {
            return _advisorDAL.Update(advisor)>0;
        }
    }
}
