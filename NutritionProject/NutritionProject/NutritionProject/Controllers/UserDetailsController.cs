using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using NutritionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserDetailsController : Controller
    {
        UserDetailsManager udm = new UserDetailsManager(new EfUserDetailDal());
        

        public ActionResult GetUserDetails()
        {
            int id;
            id = 2;
            var userdetailsvalues = udm.GetUserDetails(id);
            return View(userdetailsvalues);



        }
    }


    }
