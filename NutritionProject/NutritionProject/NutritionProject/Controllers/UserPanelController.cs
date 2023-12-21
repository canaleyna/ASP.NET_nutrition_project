using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Fluent;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace NutritionProject.Controllers
{
    public class UserPanelController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());

        public ActionResult UserProfile()
        {
            int id;
            id = 2;
            var uservalues = um.GetByID(id);
            return View(uservalues);

            //Context c = new Context();
            //p = (string)Session["Email"];
            //var useridinfo = c.Users.Where(x => x.Email == p).Select(y => y.UserID).FirstOrDefault();
            //var uservalues = um.GetByID(useridinfo);

        }



        [HttpGet]
        public ActionResult EditUser(int id)
        {
            var uservalues = um.GetByID(id);
            return View(uservalues);
        }

        [HttpPost]
        public ActionResult EditUser(User p)
        {
            UserValidator uservalidator = new UserValidator();
            ValidationResult results = uservalidator.Validate(p);
            if (results.IsValid)
            {
                um.UserUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}