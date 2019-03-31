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
    public class Student_JobOpportunityBLL : IStudent_JobOpportunityService
    {
        EFStudent_JobOpportunityDAL _student_JobOpportunity;

        public Student_JobOpportunityBLL()
        {
            _student_JobOpportunity = new EFStudent_JobOpportunityDAL();
        }
        public bool Delete(Student_JobOpportunity student_JobOpportunity)
        {
            return _student_JobOpportunity.Remove(student_JobOpportunity) > 0;
        }
     
        public Student_JobOpportunity Get(int studentID)
        {
            return _student_JobOpportunity.Get(a => a.StudentID == studentID);
        }

        public ICollection<Student_JobOpportunity> GetAll()
        {
            return _student_JobOpportunity.GetAll();
        }

        public List<Student_JobOpportunity> GetStudent_JobOpportunityByGuidID(Guid jobOpportunityID)
        {
            return _student_JobOpportunity.GetAll(a => a.JobOpportunityID == jobOpportunityID).ToList();
        }

        public List<Student_JobOpportunity> GetStudent_JobOpportunityByStudentID(int StudentID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Student_JobOpportunity student_JobOpportunity)
        {
            return _student_JobOpportunity.Add(student_JobOpportunity) > 0;
        }

        public bool Update(Student_JobOpportunity student_JobOpportunity)
        {
            return _student_JobOpportunity.Update(student_JobOpportunity) > 0;
        }

        public List<Student_JobOpportunity> GetAllByID (string id)
        {
            List<Student_JobOpportunity> jobs = new List<Student_JobOpportunity>();

            foreach (Student_JobOpportunity item in _student_JobOpportunity.GetAll())
            {
                if (item.StudentID == int.Parse(id))
                {
                    jobs.Add(item);
                }
            }

            return jobs;
        }

        public Student_JobOpportunity UpdateJopOpp(string id,Guid guidID)
        {
            List<Student_JobOpportunity> jobs = new List<Student_JobOpportunity>();

            foreach (Student_JobOpportunity item in _student_JobOpportunity.GetAll())
            {
                if (item.StudentID == int.Parse(id))
                {
                    jobs.Add(item);
                }
            }
            foreach (Student_JobOpportunity item in jobs)
            {
                if (guidID == item.JobOpportunityID)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Student_JobOpportunity> GetAllByGuidID(Guid id)
        {
            List<Student_JobOpportunity> jobs = new List<Student_JobOpportunity>();

            foreach (Student_JobOpportunity item in _student_JobOpportunity.GetAll())
            {
                if (item.JobOpportunityID == id)
                {
                    jobs.Add(item);
                }
            }

            return jobs;
        }
    }
}
