using JobOpportunities.BLL.Concrete;
using JobOpportunities.Entities;
using JobOpportunities.UI.MVC.Models;
using JobOpportunities.UI.MVC.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace JobOpportunities.UI.MVC.Controllers
{
    public class AdvisorController : Controller
    {

        JobOpportunityBLL _jobOpportunityBLL;
        StudentBLL _studentBLL;
        ClanBLL _clanBLL;

        DepartmentBLL _departmentBLL;
        ContractBLL _contractBLL;
        TeacherBLL _teacherBLL;
        UserAccountBLL _userAccountBLL;
        Student_JobOpportunityBLL _student_JobOpportunityBLL;

        public AdvisorController()
        {
            _jobOpportunityBLL = new JobOpportunityBLL();
            _studentBLL = new StudentBLL();
            _clanBLL = new ClanBLL();
            _contractBLL = new ContractBLL();
            _departmentBLL = new DepartmentBLL();
            _teacherBLL = new TeacherBLL();
            _userAccountBLL = new UserAccountBLL();
            _student_JobOpportunityBLL = new Student_JobOpportunityBLL();
        }

        
        public ActionResult MainPage()
        {
            List<SelectListItem> jobOpportunities = new List<SelectListItem>();

            BindDepartmentsToDDL();
            List<JobOpportunity> jobs = _jobOpportunityBLL.GetAll().ToList();

            return View(jobs.ToList());
        }

        private void BindDepartmentsToDDL()
        {
            List<SelectListItem> departments = new List<SelectListItem>();

            foreach (Department item in _departmentBLL.GetAll())
            {

                departments.Add(new SelectListItem()
                {
                    Text = item.DepartmentName,
                    Value = item.DepartmentID.ToString()
                });

            }
            ViewBag.Departments = departments;
        }

        private void BindContractsToDDL()
        {
            List<SelectListItem> contracts = new List<SelectListItem>();

            foreach (Contract item in _contractBLL.GetAll())
            {

                contracts.Add(new SelectListItem()
                {
                    Text = item.ContractName,
                    Value = item.ContractID.ToString()
                });

            }
            ViewBag.Contracts = contracts;
        }

        private void BindTeachersToDDL()
        {
            List<SelectListItem> teachers = new List<SelectListItem>();

            foreach (Teacher item in _teacherBLL.GetAll())
            {

                teachers.Add(new SelectListItem()
                {
                    Text = item.Name + " " + item.Surname,
                    Value = item.ID.ToString()
                });

            }
            ViewBag.Teachers = teachers;
        }

        public ActionResult JobOpportunityOperations()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobOpportunityOperations(JobOpportunity jo)
        {

            bool result = _jobOpportunityBLL.Insert(jo);


            return View();
        }

        public ActionResult StudentOperations()
        {
            BindClansToDDL();
            return View();
        }

        [HttpPost]
        public ActionResult StudentOperations(StudentCreateViewModel model)
        {

            UserAccount user = new UserAccount();
            user.Mail = model.Name.ToLower() + "." + model.Surname.ToLower();
            user.Password = model.TCKN;
            user.RoleID = 3;
            _userAccountBLL.Insert(user);
            Student student = new Student();
            student.ID = user.UserAccountID;
            student.Name = model.Name;
            student.Surname = model.Surname;
            student.TCKN = model.TCKN;
            student.CvLink = model.CvLink;
            student.ClanID = model.ClanID;
            _studentBLL.Insert(student);
            BindClansToDDL();
            return View();
        }

        private void BindClansToDDL()
        {
            List<SelectListItem> clans = new List<SelectListItem>();

            foreach (Clan item in _clanBLL.GetAll())
            {

                clans.Add(new SelectListItem()
                {
                    Text = item.PortalNo,
                    Value = item.ClanID.ToString()
                });

            }
            ViewBag.Clan = clans;
        }

        [HttpGet]
        public ActionResult ClanOperations(int contractID = 0)
        {
            ViewBag.Contracts = _contractBLL.GetAll().ToList();
            List<Clan> clanList = null;
            List<ClanListView> clanViewList = new List<ClanListView>();
            if (contractID == 0)
            {
                clanList = _clanBLL.GetAll().ToList();
            }
            else
            {
                clanList = _clanBLL.GetAllClanByContractID(contractID).ToList();
            }

            foreach (Clan item in clanList)
            {
                ClanListView c = new ClanListView();
                c.ClanID = item.ClanID;
                c.Class = item.GroupClass;
                c.PortalNo = item.PortalNo;
                c.Term = item.Term;
                c.DepartmentName = _departmentBLL.GetByID(item.DepartmentID).DepartmentName;
                Teacher t = _teacherBLL.Get(item.TeacherID.Value);
                c.TeacherName = t.Name + " " + t.Surname;
                clanViewList.Add(c);
            }

            return View(clanViewList);
        }

        [HttpGet]
        public ActionResult CreateClan()
        {
            BindContractsToDDL();
            BindTeachersToDDL();
            BindDepartmentsToDDL();
            return View();
        }

        [HttpPost]
        public ActionResult CreateClan(Clan clan)
        {
            try
            {
                bool result = _clanBLL.Insert(clan);
                if (result)
                {
                    return RedirectToAction("ClanOperations");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                BindContractsToDDL();
                BindTeachersToDDL();
                BindDepartmentsToDDL();
                ViewBag.IsSuccess = false;
                return View();
            }
        }

        //[HttpGet]
        //public ActionResult DeleteClan(int? clanID)
        //{
        //	if (!clanID.HasValue)
        //	{
        //		return RedirectToAction("ClanOperations");
        //	}


        //		Clan clan = _clanBLL.GetClanByID(clanID.Value);

        //		if (clan == null)
        //		{
        //			return RedirectToAction("ClanOperations");
        //		}

        //	return View(clan);
        //}

        [HttpPost]
        public ActionResult DeleteClan(Clan clan)
        {
            _clanBLL.Delete(clan);
            return RedirectToAction("ClanOperations");
        }

        public ActionResult ShowDetail()
        {
            var guidID = Request.QueryString["guidID"];
            //GetJob_Student(Guid.Parse(guidID));

            List<Student_JobOpportunity> check = new List<Student_JobOpportunity>();
            List<Student_JobOpportunity> notCheck = new List<Student_JobOpportunity>();
            List<Student_JobOpportunity> boolNull = new List<Student_JobOpportunity>();

            foreach (Student_JobOpportunity item in _student_JobOpportunityBLL.GetAllByGuidID(Guid.Parse(guidID)))
            {
                switch (item.IsApply)
                {
                    case true:
                        check.Add(item);
                        break;
                    case false:
                        notCheck.Add(item);
                        break;
                    default:
                        boolNull.Add(item);
                        break;
                }
            }
            Student_JobOpportunityViewList sjvm = new Student_JobOpportunityViewList()
            {
                JobOpportunityID = Guid.Parse(guidID),
                Check = check,
                Notcheck = notCheck,
                BoolNull = boolNull
            };
           
            return View(sjvm);
        }

    }
}