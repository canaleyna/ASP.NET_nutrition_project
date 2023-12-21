using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class BadHabbitController : Controller
    {
        BadHabbitManager bhm = new BadHabbitManager(new EfBadHabbitDal());

        public ActionResult Index()
        {
            var habbitvalues = bhm.GetList();
            return View(habbitvalues);
            
        }

        [HttpGet]
        public ActionResult AddBadHabbit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBadHabbit(BadHabbit p)
        {
            bhm.BadHabbitAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditBadHabbit(int id)
        {
            var habbitvalues = bhm.GetByID(id);
            return View(habbitvalues);
        }

        [HttpPost]
        public ActionResult EditBadHabbit(BadHabbit p)
        {
            bhm.BadHabbitUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBadHabbit(int id)
        {
            var habbitvalues = bhm.GetByID(id);
            bhm.BadHabbitDelete(habbitvalues);
            return RedirectToAction("Index");

        }
    }
}