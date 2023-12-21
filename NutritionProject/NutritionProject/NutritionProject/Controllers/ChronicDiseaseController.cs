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
    public class ChronicDiseaseController : Controller
    {
        ChronicDiseaseManager cdm = new ChronicDiseaseManager(new EfChronicDiseaseDal());

        public ActionResult Index()
        {
            var diseasevalues = cdm.GetList();
            return View(diseasevalues);
        }

        [HttpGet]
        public ActionResult AddChronicDisease()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddChronicDisease(ChronicDisease p)
        {
            cdm.ChronicDiseaseAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditChronicDisease(int id)
        {
            var diseasevalues = cdm.GetByID(id);
            return View(diseasevalues);
        }

        [HttpPost]
        public ActionResult EditChronicDisease(ChronicDisease p)
        {
            cdm.ChronicDiseaseUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteChronicDisease(int id)
        {
            var diseasevalues = cdm.GetByID(id);
            cdm.ChronicDiseaseDelete(diseasevalues);
            return RedirectToAction("Index");

        }
    }
}
