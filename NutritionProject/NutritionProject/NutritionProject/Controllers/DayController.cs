using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class DayController : Controller
    {
        DayManager dm = new DayManager(new EfDayDal());
        public ActionResult Index()
        {
            var dayvalues = dm.GetList();
            return View(dayvalues);
            

        }
    }
}