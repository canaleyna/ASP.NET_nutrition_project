using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Fluent;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserPanelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }

        public ActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}