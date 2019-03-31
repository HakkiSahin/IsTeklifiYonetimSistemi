using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobOpportunities.BLL;
using JobOpportunities.BLL.Concrete;

namespace JobOpportunities.UI.MVC.Controllers
{
    public class LoginController : Controller
    {
        UserAccountBLL _userAccountBLL;
		RoleBLL _roleBLL;
		AdvisorBLL _advisorBLL;
		StudentBLL  _studentBLL;
        public LoginController()
        {
            _userAccountBLL = new UserAccountBLL();
			_roleBLL = new RoleBLL();
			_advisorBLL = new AdvisorBLL();
			_studentBLL = new StudentBLL();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Login(UserAccount user)
        {
           UserAccount currentUser = _userAccountBLL.Get(user.Mail, user.Password);
		
            if (currentUser != null)
            {
				Role loginRole = _roleBLL.Get(currentUser.RoleID.Value);
				string role = loginRole.RoleName;
                Session["userAccountID"] = currentUser.UserAccountID;
                switch (role)
                {
                        case "Admin":
                        return RedirectToAction("MainPage", "Admin");
						
                        case "Advisor":
						Session["advisor"] = _advisorBLL.Get(currentUser.UserAccountID);
						return RedirectToAction("MainPage", "Advisor");
						
                        case "Student":
                        Session["student"] = _studentBLL.Get(currentUser.UserAccountID);
                        //Session["user"] = currentUser;
                        //return RedirectToAction("Index", "Student");
                        return RedirectToAction("Index", "Student"); 

					default:
                        return RedirectToAction("Index", "FatalError");
                }
               
            }
            else
            {
            ViewBag.Message = "Kullanıcı Adı veya Şifre Yanlış";
            return View();
            }
        }

    }
}