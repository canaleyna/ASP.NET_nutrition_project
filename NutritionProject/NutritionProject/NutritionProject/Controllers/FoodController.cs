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
    public class FoodController : Controller
    {
        FoodManager fm = new FoodManager(new EfFoodDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var foodvalues = fm.GetList();
            return View(foodvalues);
        }

        [HttpGet]
        public ActionResult AddFood()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }

        [HttpPost]
        public ActionResult AddFood(Food p)
        {
           fm.FoodAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditFood(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var foodvalue = fm.GetByID(id);
            return View(foodvalue);
        }

        [HttpPost]
        public ActionResult EditFood(Food p)
        {
            fm.FoodUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFood(int id)
        {
            var foodvalue = fm.GetByID(id);
            fm.FoodDelete(foodvalue);
            return RedirectToAction("Index");

        }
    }
}