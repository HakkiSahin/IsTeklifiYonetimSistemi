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
    public class Student_LanguageBLL : IStudent_LanguageService
    {

        EFStudent_LanguageDAL _student_LanguageDAL;

        public Student_LanguageBLL()
        {
            _student_LanguageDAL = new EFStudent_LanguageDAL();
        }
        public bool Delete(Student_Language student_Language)
        {
            return _student_LanguageDAL.Remove(student_Language) > 0;
        }

        public bool DeleteByID(int student_LanguageID)
        {
            Student_Language stu_Language = _student_LanguageDAL.Get(a => a.LanguageID == student_LanguageID);
            return _student_LanguageDAL.Remove(stu_Language) > 0;
        }




        public Student_Language Get(int student_LanguageID)
        {
            return _student_LanguageDAL.Get(a => a.LanguageID == student_LanguageID);
        }

        public ICollection<Student_Language> GetAll()
        {
            return _student_LanguageDAL.GetAll();
        }

        public bool Insert(Student_Language student_Language)
        {
            return _student_LanguageDAL.Add(student_Language) > 0;
        }

        public bool Update(Student_Language student_Language)
        {
            return _student_LanguageDAL.Update(student_Language) > 0;
        }
    }
}
