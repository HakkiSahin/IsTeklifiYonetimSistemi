using JobOpportunities.BLL.Concrete;
using JobOpportunities.Entities;
using JobOpportunities.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobOpportunities.UI.MVC.Controllers
{
    public class StudentController : Controller
    {
        Student_JobOpportunityBLL _student_JobOpportunityBLL;
        JobOpportunityBLL _jobOpportunityBLL;
        StudentBLL _studentBLL;
        LanguageBLL _languageBLL;
        SkillBLL _SkillBLL;
        Student_LanguageBLL _student_LanguageBLL;
        CityBLL _cityBLL;
        UserAccountBLL _userAccountBLL;
        
        public StudentController()
        {
            _student_JobOpportunityBLL = new Student_JobOpportunityBLL();
            _jobOpportunityBLL = new JobOpportunityBLL();
            _studentBLL = new StudentBLL();
            _languageBLL = new LanguageBLL();
            _SkillBLL = new SkillBLL();
            _student_LanguageBLL = new Student_LanguageBLL();
            _cityBLL = new CityBLL();
            _userAccountBLL = new UserAccountBLL();
        }

        
        public ActionResult Index()
        {
            //Student student = (Student)Session["student"];
            //int studentID = student.ID;

            Student stu = (Student)Session["student"];

            List<Student_JobOpportunity> studentsjobs = _student_JobOpportunityBLL.GetAllByID(stu.ID.ToString()).ToList();
            List<JobOpportunity> jobs = new List<JobOpportunity>();
            foreach (Student_JobOpportunity item in studentsjobs)
            {
                if (_jobOpportunityBLL.Get(item.JobOpportunityID) != null)
                {
                    jobs.Add(_jobOpportunityBLL.Get(item.JobOpportunityID));
                }
            }
            ViewBag.StudentID = stu.ID;
            return View(jobs.ToList());
        }


        public ActionResult DetayGoster()
        {
            var jobID = Request.QueryString["jobID"];
            Student stu = (Student)Session["student"];


            if (jobID != null)
            {
                JobOpportunity job = _jobOpportunityBLL.Get(Guid.Parse(jobID));
                JobOpportunityViewModel jvm = new JobOpportunityViewModel()
                {
                    JobOpportunityID = job.JobOpportunityID,
                    CompanyName = job.CompanyName,
                    CompanyLink = job.CompanyLink,
                    Detail = job.Detail,
                    Location = job.Location,
                    EndDate = job.EndDate,
                    Position = job.Position,
                    StudentID = stu.ID.ToString()                   
                };
                return View(jvm);
            }
            return View();
        }
        
        public ActionResult Update(JobOpportunityViewModel studentJob)
        {
            Student_JobOpportunity job = _student_JobOpportunityBLL.UpdateJopOpp(studentJob.StudentID, studentJob.JobOpportunityID);
            if (studentJob.Description == null)
            {
            job.IsApply = true;
            }
            else
            {
                job.IsApply = false;
                job.Description = studentJob.Description;
            }
            _student_JobOpportunityBLL.Update(job);
            return Json("ok",JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult StudentInformation()
        {
            Student stu = (Student)Session["student"];
            //var StudentID = Request.QueryString["studentID"];
            Student student = _studentBLL.Get(stu.ID);
            StudentViewModel svm = new StudentViewModel()
            {
                IsActive = student.IsActive,
                MilitaryState = student.MilitaryState,
                MinimumWage = student.MinimumWage,
                TotalExperience = student.TotalExperience,
                StateDescription = student.StateDescription,
                Languages = _languageBLL.GetAll().ToList(),
                Skills = _SkillBLL.GetAll().ToList(),
                Cities = _cityBLL.GetAll().ToList()
            };
            //List<Language> languages = _languageBLL.GetAll().ToList();
            //ViewBag.Languages = languages;
            //List<Skill> skills = _SkillBLL.GetAll().ToList();
            //ViewBag.Skills = skills;
            return View(svm);

        }

        public ActionResult StudentUpdate(StudentViewModel student)
        {
            Student stu = (Student)Session["student"];


            Student currentStudent = _studentBLL.Get(stu.ID);
            currentStudent.IsActive = student.IsActive;
            currentStudent.TotalExperience = student.TotalExperience;
            currentStudent.MilitaryState = student.MilitaryState;
            currentStudent.MinimumWage = student.MinimumWage;
            currentStudent.StateDescription = student.StateDescription;
            _studentBLL.Update(currentStudent);
            
            string[] language = student.Lang.Split(',');
            foreach (string item in language)
            {
                if (item!="" && item != null)
                {
                    Student_Language sl = new Student_Language();
                    sl.StudentID = stu.ID;
                    sl.LanguageID = int.Parse(item);
                    _student_LanguageBLL.Insert(sl);
                }                
            }
            string[] skill = student.Skill.Split(',');

            string[] city = student.City.Split(',');


            return Json("ok",JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChangePassword()
        {
           
            return View();
        }

        public ActionResult ChangedPassword(UserAccountViewModel userAccount)
        {
            Student stu = (Student)Session["student"];

            UserAccount user = _userAccountBLL.Get(stu.ID);
            user.Password = userAccount.Password;
            user.Mail = userAccount.Mail;
            _userAccountBLL.Update(user);
            return Json("ok",JsonRequestBehavior.AllowGet);
        }
    }
}
