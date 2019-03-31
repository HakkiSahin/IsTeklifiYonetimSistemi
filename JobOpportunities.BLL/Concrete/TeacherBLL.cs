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
    public class TeacherBLL : ITeacherService
    {
        EFTeacherDAL _teacherDAL;
        public TeacherBLL()
        {
            _teacherDAL = new EFTeacherDAL();
        }

        public bool Delete(Teacher teacher)
        {
            return _teacherDAL.Remove(teacher) > 0;
        }

        public bool DeleteByID(int teacherID)
        {
            Teacher teacher = _teacherDAL.Get(a => a.ID == teacherID);
            return _teacherDAL.Remove(teacher) > 0;
        }

        public Teacher Get(int teacherID)
        {
            return _teacherDAL.Get(a => a.ID == teacherID);
        }

        public ICollection<Teacher> GetAll()
        {
            return _teacherDAL.GetAll();
        }

        public bool Insert(Teacher teacher)
        {
            return _teacherDAL.Add(teacher) > 0;
        }

        public bool Update(Teacher teacher)
        {
            return _teacherDAL.Update(teacher) > 0;
        }
    }
}
