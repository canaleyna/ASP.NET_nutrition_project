using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserDayTimeController : Controller
    {
        UserDayTimeManager udtm = new UserDayTimeManager(new EfUserDayTimeDal());
        // GET: UserDayTime
        [HttpGet()]
        public ActionResult GetUserDayTimeDetails()
        {
            int id;
            id = 2;
            var result = udtm.GetUserDayTimeDetails(id);

            return View(result);
        }
    }
}