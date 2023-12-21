using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NutritionProject.Controllers
{

    public class LoginController : Controller
    {   
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x=>x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if(adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }

        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(User p)
        {
            Context c = new Context();
            var userinfo = c.Users.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Email, false);
                Session["Email"] = userinfo.Email;
                return RedirectToAction("UserProfile", "UserPanel");
            }
            else
            {
                return RedirectToAction("UserLogin");
            }
           
        }
    }
}