using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Fluent;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        UserDetailsManager udm = new UserDetailsManager(new EfUserDetailDal());

        public ActionResult Index()
        {
            var uservalue = um.GetList();
            return View(uservalue);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User p)
        {
            UserValidator uservalidator = new UserValidator();
            ValidationResult results = uservalidator.Validate(p);
            if(results.IsValid)
            {
                um.UserAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

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


        [HttpGet()]
        public ActionResult GetUserDetails(int id)
        {
            var result = um.GetUserDetails(id);

            return View(result);
        }
    }
}