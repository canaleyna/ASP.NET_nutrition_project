using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class DefaultController : Controller
    {
       CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Category()
        {
            var categorylist = cm.GetList();
            return View(categorylist);
        }
        

        public ActionResult Index()
        {
            return View();
        }
    }
}