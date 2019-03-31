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
    public class StudentBLL : IStudentService
    {

        EFStudentDAL _studentDAL;
        public StudentBLL()
        {
            _studentDAL = new EFStudentDAL();

        }

        public bool Delete(Student student)
        {
            return _studentDAL.Remove(student) > 0;
        }

        public bool DeleteByID(int studentID)
        {
            Student student = _studentDAL.Get(a => a.ID == studentID);
            return _studentDAL.Remove(student) > 0;
        }

        public Student Get(int studentID)
        {
            return _studentDAL.Get(a => a.ID == studentID);
        }

        public ICollection<Student> GetAll()
        {
            return _studentDAL.GetAll();
        }

        public List<Student_Language> GetAllByStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetAllSkillByStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetByID(int studentID)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByPortalNo(int portalNo)
        {
            return _studentDAL.GetAll(a => a.ClanID == portalNo).ToList();
        }

        public List<Student> GetStudentsByPortalNo(string portalNo)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Student student)
        {
            return _studentDAL.Add(student) > 0;
        }

        public bool Update(Student student)
        {
            return _studentDAL.Update(student) > 0;
        }
    }
}
