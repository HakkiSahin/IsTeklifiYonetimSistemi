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
    public class SkillBLL : ISkillService
    {

        EFSkillDAL _skillDAL;
        public SkillBLL()
        {
            _skillDAL = new EFSkillDAL();
        }
        public bool Delete(Skill skill)
        {

            return _skillDAL.Remove(skill) > 0;
        }

        public bool DeleteByID(int skillID)
        {
            Skill skill = _skillDAL.Get(a => a.SkillID == skillID);
            return _skillDAL.Remove(skill) > 0;
        }

        public Skill Get(int skillID)
        {
            return _skillDAL.Get(a => a.SkillID == skillID);
        }

        public ICollection<Skill> GetAll()
        {
            return _skillDAL.GetAll();
        }

        public bool Insert(Skill skill)
        {
            return _skillDAL.Add(skill) > 0;
        }

        public bool Update(Skill skill)
        {
            return _skillDAL.Update(skill) > 0;
        }
    }
}
