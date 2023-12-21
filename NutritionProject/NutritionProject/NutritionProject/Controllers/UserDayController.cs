using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.DTO;
using System;
using NutritionProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Concrete;

namespace NutritionProject.Controllers
{
    public class UserDayController : Controller
    {

        UserDayManager udm = new UserDayManager(new EfUserDayDal());
        DayManager dm = new DayManager(new EfDayDal());


        [HttpGet()]
        public ActionResult GetUserDayDetails()
        {
            int id;
            id = 2;
            var result = udm.GetUserDayDetails(id);
            return View(result);
        }



        //[HttpGet]
        //public ActionResult AddDayDetails()
        //{
        //    List<SelectListItem> valueday = (from x in dm.GetList()
        //                                          select new SelectListItem
        //                                          {
        //                                              Text = x.DayName,
        //                                              Value = x.DayID.ToString()
        //                                          }).ToList();
        //    ViewBag.vlc = valueday;
        //    return View();
        //}



        //[HttpPost]
        //public ActionResult AddDayDetails(Day p)
        //{
        //    dm.DayAdd(p);
        //    return RedirectToAction("Index");
        //}
    }
}